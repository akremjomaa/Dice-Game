using MediatR;

namespace DéApplication.Features.NumberedDies.Commands.DeleteNumberedDie
{
    public class DeleteNumberedDieCommand : IRequest
    {
        public DeleteNumberedDieCommand(int id)
        {
            DieId = id;

        }
        public int DieId { get; set; }
    }
}
