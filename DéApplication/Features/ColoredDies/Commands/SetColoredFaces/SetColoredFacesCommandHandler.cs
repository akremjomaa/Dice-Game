using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredDies.Commands.SetColoredFaces
{
    public class SetColoredFacesCommandHandler: IRequestHandler<SetColoredFacesCommand>
    {
        private readonly IRepository<ColoredDie> _coloredDieRepository;
        private readonly IMapper _mapper;
        public SetColoredFacesCommandHandler(IRepository<ColoredDie> coloredDieRepository, IMapper mapper)
        {
            _coloredDieRepository = coloredDieRepository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(SetColoredFacesCommand request, CancellationToken cancellationToken)
        {
            if (request.ColoredDieColoredFaces != null && request.ColoredDieColoredFaces.Count > 0)
            {
                var coloredFacesToAdd = new List<ColoredDieColoredFace>();
                var dieToUpdate = await _coloredDieRepository.GetByIdAsync(request.ColoredDieColoredFaces.FirstOrDefault().DieId);
                foreach(var df in request.ColoredDieColoredFaces)
                {
                    var dieColoredFace = _mapper.Map<ColoredDieColoredFace>(df);
                    coloredFacesToAdd.Add(dieColoredFace);
                }
                dieToUpdate.AddColoredDieColoredFaces(coloredFacesToAdd);
                await _coloredDieRepository.UpdateAsync(dieToUpdate);
            }
            return Unit.Value;
        }
    }
}
