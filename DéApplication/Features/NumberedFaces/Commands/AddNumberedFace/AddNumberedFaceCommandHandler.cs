using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedFaces.Commands.AddNumberedFace
{
    public class AddNumberedFaceCommandHandler : IRequestHandler<AddNumberedFaceCommand, int>
    {
        private readonly IRepository<NumberedFace> _numberedFaceRepository;
        private readonly IMapper _mapper;
        public AddNumberedFaceCommandHandler(IRepository<NumberedFace> numberedFaceRepository, IMapper mapper)
        {
            _numberedFaceRepository = numberedFaceRepository;
            _mapper = mapper;

        }

        public async Task<int> Handle(AddNumberedFaceCommand request, CancellationToken cancellationToken)
        {
            var numberedFace = _mapper.Map<NumberedFace>(request);
            numberedFace = await _numberedFaceRepository.AddAsync(numberedFace);
            return numberedFace.NumberedFaceId;
        }
    }
}
