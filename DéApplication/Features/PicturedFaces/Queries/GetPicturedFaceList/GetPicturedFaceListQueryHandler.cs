using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.PicturedFaces.Queries.GetPicturedFaceList
{
    public class GetPicturedFaceListQueryHandler : IRequestHandler<GetPicturedFaceListQuery, List<PicturedFaceDto>>
    {
        private readonly IRepository<PicturedFace> _picturedFaceRepository;
        private readonly IMapper _mapper;
        public GetPicturedFaceListQueryHandler(IRepository<PicturedFace> picturedFaceRepository, IMapper mapper)
        {
            _picturedFaceRepository = picturedFaceRepository;
            _mapper = mapper;

        }

        public async Task<List<PicturedFaceDto>> Handle(GetPicturedFaceListQuery request, CancellationToken cancellationToken)
        {
            var picturedFaces = (await _picturedFaceRepository.ListAsync(cancellationToken)).OrderBy(x => x.PicturedFaceId);
            return _mapper.Map<List<PicturedFaceDto>>(picturedFaces);
        }
    }
}
