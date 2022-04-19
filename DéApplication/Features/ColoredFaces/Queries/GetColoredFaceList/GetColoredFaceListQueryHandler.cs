using AutoMapper;
using DéApplication.Entities;
using DéApplication.Features.ColoredFaces.Queries.GetColoredFaceList;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredFaces.Queries.GetColoredFaceList
{
    public class GetColoredFaceListQueryHandler : IRequestHandler<GetColoredFaceListQuery, List<ColoredFaceDto>>
    {
        private readonly IRepository<ColoredFace> _coloredFaceRepository;
        private readonly IMapper _mapper;
        public GetColoredFaceListQueryHandler(IMapper mapper, IRepository<ColoredFace> coloredFaceRepository)
        {
            _mapper = mapper;
            _coloredFaceRepository = coloredFaceRepository;

        }

        public async Task<List<ColoredFaceDto>> Handle(GetColoredFaceListQuery request, CancellationToken cancellationToken)
        {
           var coloredFaces =(await _coloredFaceRepository.ListAsync(cancellationToken)).OrderBy(x=>x.ColoredFaceId);
            return _mapper.Map<List<ColoredFaceDto>>(coloredFaces);
        }
    }
}
