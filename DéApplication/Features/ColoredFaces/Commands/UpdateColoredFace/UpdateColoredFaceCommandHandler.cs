using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredFaces.Commands.UpdateColoredFace
{
    public class UpdateColoredFaceCommandHandler : IRequestHandler<UpdateColoredFaceCommand>
    {
        private readonly IRepository<ColoredFace> _coloredFaceRepository;
        private readonly IMapper _mapper;
        public UpdateColoredFaceCommandHandler()
        {

        }
        public UpdateColoredFaceCommandHandler(IRepository<ColoredFace> coloredFaceRepository, IMapper mapper)
        {
            _coloredFaceRepository = coloredFaceRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateColoredFaceCommand request, CancellationToken cancellationToken)
        {
            var coloredFaceToUpdate = await _coloredFaceRepository.GetByIdAsync(request.ColoredFaceId);
            _mapper.Map(request, coloredFaceToUpdate, typeof(UpdateColoredFaceCommand), typeof(ColoredFace));
            await _coloredFaceRepository.UpdateAsync(coloredFaceToUpdate, cancellationToken);
            return Unit.Value;
        }
    }
}
