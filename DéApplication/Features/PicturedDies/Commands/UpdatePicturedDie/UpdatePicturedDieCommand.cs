using MediatR;

namespace DéApplication.Features.PicturedDies.Commands.UpdatePicturedDie
{
    public class UpdatePicturedDieCommand:IRequest
    {
        public UpdatePicturedDieCommand()
        {

        }
        public UpdatePicturedDieCommand(int id , string title)
        {
            DieId = id;
            Title = title;

        }
        public int DieId { get; set; }
        public string Title { get; set; }
    }
}
