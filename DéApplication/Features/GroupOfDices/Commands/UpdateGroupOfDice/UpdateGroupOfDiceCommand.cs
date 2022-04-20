using MediatR;

namespace DéApplication.Features.GroupOfDices.Commands.UpdateGroupOfDice
{
    public class UpdateGroupOfDiceCommand : IRequest
    {
        public UpdateGroupOfDiceCommand(int id , string title)
        {
            GroupOfDiceId = id;
            Title = title;

        }
        public int GroupOfDiceId { get; set; }
        public string Title { get; set; }
    }
}
