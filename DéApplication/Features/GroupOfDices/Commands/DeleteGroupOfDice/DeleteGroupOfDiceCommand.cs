using MediatR;

namespace DéApplication.Features.GroupOfDices.Commands.DeleteGroupOfDice
{
    public class DeleteGroupOfDiceCommand : IRequest
    {
        public DeleteGroupOfDiceCommand(int groupOfDiceId)
        {
            GroupOfDiceId = groupOfDiceId;
        }

        public int GroupOfDiceId { get; set; }
    }
}
