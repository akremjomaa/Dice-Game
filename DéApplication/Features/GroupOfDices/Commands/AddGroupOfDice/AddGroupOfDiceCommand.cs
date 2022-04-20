using MediatR;

namespace DéApplication.Features.GroupOfDices.Commands.AddGroupOfDice
{
    public class AddGroupOfDiceCommand : IRequest<int>
    {
        public AddGroupOfDiceCommand()
        {

        }
        public AddGroupOfDiceCommand(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
    }
}
