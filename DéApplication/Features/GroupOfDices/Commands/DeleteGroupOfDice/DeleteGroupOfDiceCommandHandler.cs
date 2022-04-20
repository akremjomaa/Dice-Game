using DéApplication.Entities;
using DéApplication.Repositories.Interfaces;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Commands.DeleteGroupOfDice
{
    public class DeleteGroupOfDiceCommandHandler : IRequestHandler<DeleteGroupOfDiceCommand>
    {
        private readonly IRepository<GroupOfDice> _groupOfDiceRepository;
        public DeleteGroupOfDiceCommandHandler(IRepository<GroupOfDice> groupOfDiceRepository)
        {
           _groupOfDiceRepository = groupOfDiceRepository;

        }

        public async Task<Unit> Handle(DeleteGroupOfDiceCommand request, CancellationToken cancellationToken)
        {
            var groupOfDiceToDelete = await _groupOfDiceRepository.GetByIdAsync(request.GroupOfDiceId);
            await _groupOfDiceRepository.DeleteAsync(groupOfDiceToDelete);
            return Unit.Value;
        }
    }
}
