using MediatR;

namespace DéApplication.Features.ColoredDies.Commands.UpdateColoredDie
{
    public class UpdateColoredDieCommand : IRequest
    {
        public UpdateColoredDieCommand(int id , string title)
        {
            DieId = id;
            Title = title;

        }
        public int DieId { get; set; }
        public string Title { get; set; }
    }
}
