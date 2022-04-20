using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Commands.AddGroupOfDice
{
    public class AddGroupOfDiceCommandHandler : IRequestHandler<AddGroupOfDiceCommand, int>
    {
        private readonly IRepository<GroupOfDice> _groupOfDiceRepository;
        private readonly IMapper _mapper;
        public AddGroupOfDiceCommandHandler(IRepository<GroupOfDice> groupOfDiceRepository, IMapper mapper)
        {
            _groupOfDiceRepository = groupOfDiceRepository;
            _mapper = mapper;

        }

        public async Task<int> Handle(AddGroupOfDiceCommand request, CancellationToken cancellationToken)
        {
            var groupOfDice = _mapper.Map<GroupOfDice>(request);
            groupOfDice = await _groupOfDiceRepository.AddAsync(groupOfDice);
            return groupOfDice.GroupOfDiceId;
        }
    }
}
