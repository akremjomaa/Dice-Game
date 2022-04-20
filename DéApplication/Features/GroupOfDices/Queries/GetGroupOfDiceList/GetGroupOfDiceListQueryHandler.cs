using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Queries.GetGroupOfDiceList
{
    public class GetGroupOfDiceListQueryHandler : IRequestHandler<GetGroupOfDiceListQuery, List<GroupOfDiceDto>>
    {
        private readonly IRepository<GroupOfDice> _groupOfDiceRepository;
        private readonly IMapper _mapper;
        public GetGroupOfDiceListQueryHandler(IRepository<GroupOfDice> repository, IMapper mapper)
        {
            _groupOfDiceRepository = repository;
            _mapper = mapper;

        }
        public async Task<List<GroupOfDiceDto>> Handle(GetGroupOfDiceListQuery request, CancellationToken cancellationToken)
        {
            var all = (await _groupOfDiceRepository.ListAsync(cancellationToken)).OrderBy(x => x.GroupOfDiceId);
            return _mapper.Map<List<GroupOfDiceDto>>(all);
        }
    }
}
