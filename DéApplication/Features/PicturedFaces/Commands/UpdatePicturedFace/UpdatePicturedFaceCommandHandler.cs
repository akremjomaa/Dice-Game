using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedFaces.Commands.UpdatePicturedFace
{
    public class UpdatePicturedFaceCommandHandler : IRequestHandler<UpdatePicturedFaceCommand>
    {
        private readonly IRepository<PicturedFace> _picturedFaceRepository;
        private readonly IMapper _mapper;
        public UpdatePicturedFaceCommandHandler(IRepository<PicturedFace> picturedFaceRepository, IMapper mapper)
        {
            _picturedFaceRepository = picturedFaceRepository;
            _mapper = mapper;

        }
        public async Task<Unit> Handle(UpdatePicturedFaceCommand request, CancellationToken cancellationToken)
        {
            var picturedFaceToUpdate = await _picturedFaceRepository.GetByIdAsync(request.PicturedFaceId);
            _mapper.Map(request, picturedFaceToUpdate, typeof(UpdatePicturedFaceCommand), typeof(PicturedFace));
            await _picturedFaceRepository.UpdateAsync(picturedFaceToUpdate, cancellationToken);
            return Unit.Value;
        }
    }
}
