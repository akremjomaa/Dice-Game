using MediatR;

namespace DéApplication.Features.ColoredDies.Commands.DeleteColoredDie
{
    public class DeleteColoredDieCommand:IRequest
    {
        public DeleteColoredDieCommand(int dieId)
        {
            DieId = dieId;
        }

        public int DieId { get; set; } 
    }
}
