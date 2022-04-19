using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredDies.Commands.UpdateColoredDie
{
    public class UpdateColoredDieCommandHandler : IRequestHandler<UpdateColoredDieCommand>
    {
        private readonly IRepository<ColoredDie> _coloredDieRepository;
        private readonly IMapper _mapper;
        public UpdateColoredDieCommandHandler(IRepository<ColoredDie> coloredDieRepository, IMapper mapper)
        {
            _mapper = mapper;
            _coloredDieRepository = coloredDieRepository;

        }
        public async Task<Unit> Handle(UpdateColoredDieCommand request, CancellationToken cancellationToken)
        {

            var coloredDieToUpdate = await _coloredDieRepository.GetByIdAsync(request.DieId);
            _mapper.Map(request, coloredDieToUpdate, typeof(UpdateColoredDieCommand), typeof(ColoredFace));
            await _coloredDieRepository.UpdateAsync(coloredDieToUpdate, cancellationToken);
            return Unit.Value;
        }
    }
}
