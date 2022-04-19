using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedFaces.Queries.GetNumberedFaceList
{
    public class GetNumberedFaceListQueryHandler : IRequestHandler<GetNumberedFaceListQuery, List<NumberedFaceDto>>
    {
        private readonly IRepository<NumberedFace> _numberedFaceRepository;
        private readonly IMapper _mapper;
        public GetNumberedFaceListQueryHandler(IRepository<NumberedFace> numberedFaceRepository, IMapper mapper)
        {
            _numberedFaceRepository = numberedFaceRepository;
            _mapper = mapper;

        }
        public async Task<List<NumberedFaceDto>> Handle(GetNumberedFaceListQuery request, CancellationToken cancellationToken)
        {
            var numberedFaces = (await _numberedFaceRepository.ListAsync(cancellationToken)).OrderBy(x => x.NumberedFaceId);
            return _mapper.Map<List<NumberedFaceDto>>(numberedFaces);
        }
    }
}
