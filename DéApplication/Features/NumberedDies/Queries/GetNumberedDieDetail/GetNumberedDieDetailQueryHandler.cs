using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedDies.Queries.GetNumberedDieDetail
{
    public class GetNumberedDieDetailQueryHandler : IRequestHandler<GetNumberedDieDetailQuery, NumberedDieDto>
    {
        private readonly IRepository<NumberedDie> _numberedDieRepository;
        private readonly IMapper _mapper;
        public GetNumberedDieDetailQueryHandler(IRepository<NumberedDie> numberedDieRepository, IMapper mapper)
        {
            _numberedDieRepository = numberedDieRepository;
            _mapper = mapper;

        }

        public async Task<NumberedDieDto> Handle(GetNumberedDieDetailQuery request, CancellationToken cancellationToken)
        {
            var numberedDie = await _numberedDieRepository.GetByIdAsync(request.DieId);
            var numberedDieDto = _mapper.Map<NumberedDieDto>(numberedDie);
            return numberedDieDto;
        }
    }
}
