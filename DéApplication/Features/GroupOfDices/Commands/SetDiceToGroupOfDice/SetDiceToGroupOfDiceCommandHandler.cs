
using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Commands.SetDiceToGroupOfDice
{
    public class SetDiceToGroupOfDiceCommandHandler : IRequestHandler<SetDiceToGroupOfDiceCommand>
    {
        private readonly IRepository<GroupOfDice> _groupOfDiceRepository;
        private readonly IMapper _mapper;
        public SetDiceToGroupOfDiceCommandHandler(IRepository<GroupOfDice> groupOfDiceRepository, IMapper mapper)
        {

            _groupOfDiceRepository = groupOfDiceRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(SetDiceToGroupOfDiceCommand request, CancellationToken cancellationToken)
        {
            if (request.DieGroupOfDice != null && request.DieGroupOfDice.Count > 0)
            {
                var diesToAdd = new List<DieGroupOfDice>();
                var groupOfDiceToUpdate = await _groupOfDiceRepository.GetByIdAsync(request.DieGroupOfDice.FirstOrDefault().GroupOfDieId);
                foreach (var gd in request.DieGroupOfDice)
                {
                    var groupOfDice = _mapper.Map<DieGroupOfDice>(gd);
                    diesToAdd.Add(groupOfDice);
                }
                groupOfDiceToUpdate.AddDiceToGroupOfDice(diesToAdd);
                await _groupOfDiceRepository.UpdateAsync(groupOfDiceToUpdate);
            }
            return Unit.Value;
        }
    }
}
