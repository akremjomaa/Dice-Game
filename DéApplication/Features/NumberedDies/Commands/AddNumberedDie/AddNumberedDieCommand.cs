using MediatR;

namespace DéApplication.Features.NumberedDies.Commands.AddNumberedDie
{
    public class AddNumberedDieCommand:IRequest<int>
    {
        public AddNumberedDieCommand(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
    }
}
