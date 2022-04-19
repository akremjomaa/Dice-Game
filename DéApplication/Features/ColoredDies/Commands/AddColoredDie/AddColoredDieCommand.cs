using MediatR;

namespace DéApplication.Features.ColoredDies.Commands.AddColoredDie
{
    public class AddColoredDieCommand : IRequest<int>
    {
        public AddColoredDieCommand(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
    }
}
