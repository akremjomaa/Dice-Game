using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedFaces.Queries.GetNumberedFaceDetail
{
    public class GetNumberedFaceDetailQueryHandler : IRequestHandler<GetNumberedFaceDetailQuery, NumberedFaceDto>
    {
        private readonly IRepository<NumberedFace> _numberedFaceRepository;
        private readonly IMapper _mapper;
        public GetNumberedFaceDetailQueryHandler(IRepository<NumberedFace> numberedFaceRepository, IMapper mapper) 
        {
            _numberedFaceRepository = numberedFaceRepository;
            _mapper = mapper;

        }
        public async Task<NumberedFaceDto> Handle(GetNumberedFaceDetailQuery request, CancellationToken cancellationToken)
        {
            var numberedFace = await _numberedFaceRepository.GetByIdAsync(request.Id);
            var numberedFaceDto = _mapper.Map<NumberedFaceDto>(numberedFace);
            return numberedFaceDto;
        }
    }
}
