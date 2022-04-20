using AutoMapper;
using DéApplication.Entities;
using DéApplication.Models;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Queries.GetGroupOfDiceDetail
{
    public class GetGroupOfDiceDetailQueryHandler : IRequestHandler<GetGroupOfDiceDetailQuery, GroupOfDiceDto>
    {
        private readonly IRepository<GroupOfDice> _groupOfDiceRepository;
        private readonly IMapper _mapper;
        public GetGroupOfDiceDetailQueryHandler(IRepository<GroupOfDice> groupOfDiceRepository, IMapper mapper)
        {
            _groupOfDiceRepository = groupOfDiceRepository;
            _mapper = mapper;

        }

        public async Task<GroupOfDiceDto> Handle(GetGroupOfDiceDetailQuery request, CancellationToken cancellationToken)
        {
            var groupOfDice = await _groupOfDiceRepository.GetByIdAsync(request.GroupOfDiceId);
            var groupOfDiceDto = _mapper.Map<GroupOfDiceDto>(groupOfDice);
            return groupOfDiceDto;
        }
    }
}
