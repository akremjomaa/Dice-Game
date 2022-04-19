using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.NumberedDies.Queries.GetNumberedDieList
{
    public class GetNumberedDieListQueryHandler : IRequestHandler<GetNumberedDieListQuery, List<NumberedDieDto>>
    {
        private readonly IRepository<NumberedDie> _numberedDieRepository;
        private readonly IMapper _mapper;
        public GetNumberedDieListQueryHandler(IRepository<NumberedDie> numberedDieRepository, IMapper mapper)
        {
            _numberedDieRepository = numberedDieRepository;
            _mapper = mapper;

        }

        public async Task<List<NumberedDieDto>> Handle(GetNumberedDieListQuery request, CancellationToken cancellationToken)
        {
            var numberedDies = (await _numberedDieRepository.ListAsync(cancellationToken)).OrderBy(x => x.DieId);
            return _mapper.Map<List<NumberedDieDto>>(numberedDies);
        }
    }
}
