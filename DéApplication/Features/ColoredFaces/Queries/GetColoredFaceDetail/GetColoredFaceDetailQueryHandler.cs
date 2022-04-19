using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.ColoredFaces.Queries.GetColoredFaceDetail
{
    public class GetColoredFaceDetailQueryHandler : IRequestHandler<GetColoredFaceDetailQuery, ColoredFaceDto>
    {
        private readonly IRepository<ColoredFace> _coloredFaceRepository;
        private readonly IMapper _mapper;
        public GetColoredFaceDetailQueryHandler(IMapper mapper, IRepository<ColoredFace> coloredFaceRepository)
        {
            _mapper = mapper;
            _coloredFaceRepository = coloredFaceRepository;

        }
        public async Task<ColoredFaceDto> Handle(GetColoredFaceDetailQuery request, CancellationToken cancellationToken)
        {
           var coloredFace = await _coloredFaceRepository.GetByIdAsync(request.Id);
            var coloredFaceDto = _mapper.Map<ColoredFaceDto>(coloredFace);
            return coloredFaceDto;
        }
    }
}
