using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedDies.Commands.UpdatePicturedDie
{
    public class UpdatePicturedDieCommandHandler : IRequestHandler<UpdatePicturedDieCommand>
    {
        private readonly IRepository<PicturedDie> _picturedDieRepository;
        private readonly IMapper _mapper;
        public UpdatePicturedDieCommandHandler(IRepository<PicturedDie> picturedDieRepository, IMapper mapper)
        {
            _picturedDieRepository = picturedDieRepository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(UpdatePicturedDieCommand request, CancellationToken cancellationToken)
        {
            var picturedDieToUpdate = await _picturedDieRepository.GetByIdAsync(request.DieId);
            _mapper.Map(request, picturedDieToUpdate, typeof(UpdatePicturedDieCommand), typeof(NumberedFace));
            await _picturedDieRepository.UpdateAsync(picturedDieToUpdate, cancellationToken);
            return Unit.Value;
        }
    }
}
