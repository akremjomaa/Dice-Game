using MediatR;

namespace DéApplication.Features.NumberedDies.Commands.UpdateNumberedDie
{
    public class UpdateNumberedDieCommand : IRequest
    {
        public UpdateNumberedDieCommand()
        {

        }
        public UpdateNumberedDieCommand(int id,string title)
        {
            DieId = id;
            Title = title;

        }
        public int DieId { get; set; }
        public string Title { get; set; }

    }
}
