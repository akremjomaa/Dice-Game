using MediatR;

namespace DéApplication.Features.PicturedDies.Commands.AddPicturedDie
{
    public class AddPicturedDieCommand : IRequest<int>
    {
        public AddPicturedDieCommand(string title)
        {
            Title = title;
        }

        public string Title  { get; set; }
    }
}
