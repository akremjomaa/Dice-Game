using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedFaces.Commands.AddPicturedFace
{
    public class AddPicturedFaceCommandHandler : IRequestHandler<AddPicturedFaceCommand, int>
    {
    
        private readonly IRepository<PicturedFace> _picturedFaceRepository;
        private readonly IMapper _mapper;
        public AddPicturedFaceCommandHandler(IRepository<PicturedFace> picturedFaceRepository, IMapper mapper)
        {
            _picturedFaceRepository = picturedFaceRepository;
            _mapper = mapper;

        }

        public async Task<int> Handle(AddPicturedFaceCommand request, CancellationToken cancellationToken)
        {
            var picturedFace = _mapper.Map<PicturedFace>(request);
            picturedFace = await _picturedFaceRepository.AddAsync(picturedFace);
            return picturedFace.PicturedFaceId;
        }
    }
}
