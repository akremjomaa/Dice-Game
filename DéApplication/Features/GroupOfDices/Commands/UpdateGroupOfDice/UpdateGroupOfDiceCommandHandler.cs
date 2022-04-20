using AutoMapper;
using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Commands.UpdateGroupOfDice
{
    public class UpdateGroupOfDiceCommandHandler : IRequestHandler<UpdateGroupOfDiceCommand>
    {
        private readonly IRepository<GroupOfDice> _groupOfDiceRepository;
        private readonly IMapper _mapper;
        public UpdateGroupOfDiceCommandHandler(IRepository<GroupOfDice> groupOfDiceRepository, IMapper mapper)
        {
            _groupOfDiceRepository = groupOfDiceRepository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(UpdateGroupOfDiceCommand request, CancellationToken cancellationToken)
        {
            var groupOfDiceToUpdate = await _groupOfDiceRepository.GetByIdAsync(request.GroupOfDiceId);
            _mapper.Map(request, groupOfDiceToUpdate, typeof(UpdateGroupOfDiceCommand), typeof(GroupOfDice));
            await _groupOfDiceRepository.UpdateAsync(groupOfDiceToUpdate);
            return Unit.Value;
        }
    }
}
