using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedFaces.Queries.GetPicturedFaceDetail
{
    public class GetPicturedFaceDetailQueryHandler : IRequestHandler<GetPicturedFaceDetailQuery, PicturedFaceDto>
    {
        private readonly IRepository<PicturedFace> _picturedFaceRepository;
        private readonly IMapper _mapper;
        public GetPicturedFaceDetailQueryHandler(IRepository<PicturedFace> picturedFaceRepository, IMapper mapper)
        {
            _picturedFaceRepository = picturedFaceRepository;
            _mapper = mapper;

        }

        public async Task<PicturedFaceDto> Handle(GetPicturedFaceDetailQuery request, CancellationToken cancellationToken)
        {
            var picturedFace = await _picturedFaceRepository.GetByIdAsync(request.PicturedFaceId);
            var picturedFaceDto = _mapper.Map<PicturedFaceDto>(picturedFace);
            return picturedFaceDto;
        }
    }
}
