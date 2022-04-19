using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedFaces.Commands.DeleteNumberedFace
{
    public class DeleteNumberedFaceCommandHandler : IRequestHandler<DeleteNumberedFaceCommand>
    {
        private readonly IRepository<NumberedFace> _numberedFaceRepository;
        public DeleteNumberedFaceCommandHandler(IRepository<NumberedFace> numberedFaceRepository)
        {
            _numberedFaceRepository = numberedFaceRepository;

        }

        public async Task<Unit> Handle(DeleteNumberedFaceCommand request, CancellationToken cancellationToken)
        {
            var numeredFaceToDelete = await _numberedFaceRepository.GetByIdAsync(request.NumberedFaceId);
            await _numberedFaceRepository.DeleteAsync(numeredFaceToDelete);
            return Unit.Value;
        }
    }
}
