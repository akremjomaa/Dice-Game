using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedFaces.Commands.DeletePicturedFace
{
    public class DeletePicturedFaceCommandHandler : IRequestHandler<DeletePicturedFaceCommand>
    {
        private readonly IRepository<PicturedFace> _picturedFaceRepository;
        private readonly IMapper _mapper;
        public DeletePicturedFaceCommandHandler(IRepository<PicturedFace> picturedFaceRepository, IMapper mapper)
        {
            _picturedFaceRepository = picturedFaceRepository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(DeletePicturedFaceCommand request, CancellationToken cancellationToken)
        {
            var picturedFaceToDelete = await _picturedFaceRepository.GetByIdAsync(request.PicturedFaceId);
            await _picturedFaceRepository.DeleteAsync(picturedFaceToDelete);
            return Unit.Value;
        }
    }
}
