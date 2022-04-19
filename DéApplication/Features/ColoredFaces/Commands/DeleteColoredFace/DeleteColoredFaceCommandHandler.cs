using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredFaces.Commands.DeleteColoredFace
{
    public class DeleteColoredFaceCommandHandler:IRequestHandler<DeleteColoredFaceCommand>
    {
        private readonly IRepository<ColoredFace> _coloredFaceRepository;
        public DeleteColoredFaceCommandHandler(IRepository<ColoredFace> coloredFaceRepository)
        {
            _coloredFaceRepository = coloredFaceRepository;

        }

        public async Task<Unit> Handle(DeleteColoredFaceCommand request, CancellationToken cancellationToken)
        {
            var coloredFaceToDelete = await _coloredFaceRepository.GetByIdAsync(request.ColoredFaceId);
           await _coloredFaceRepository.DeleteAsync(coloredFaceToDelete);
            return Unit.Value;
        }
    }
}
