using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedDies.Commands.UpdateNumberedDie
{
    public class UpdateNumberedDieCommandHandler : IRequestHandler<UpdateNumberedDieCommand>
    {
        private readonly IRepository<NumberedDie> _numberedDieRepository;
        private readonly IMapper _mapper;
        public UpdateNumberedDieCommandHandler(IRepository<NumberedDie> numberedDieRepository, IMapper mapper)
        {
            _numberedDieRepository = numberedDieRepository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(UpdateNumberedDieCommand request, CancellationToken cancellationToken)
        {
            var numberedDieToUpdate = await _numberedDieRepository.GetByIdAsync(request.DieId);
            _mapper.Map(request, numberedDieToUpdate, typeof(UpdateNumberedDieCommand), typeof(NumberedFace));
            await _numberedDieRepository.UpdateAsync(numberedDieToUpdate, cancellationToken);
            return Unit.Value;
        }
    }
}
