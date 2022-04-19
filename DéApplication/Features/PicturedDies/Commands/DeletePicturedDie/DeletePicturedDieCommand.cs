using MediatR;

namespace DéApplication.Features.PicturedDies.Commands.DeletePicturedDie
{
    public class DeletePicturedDieCommand : IRequest
    {
        public DeletePicturedDieCommand(int id)
        {
            DieId = id;
        }
        public int DieId { get; set; }
    }
}
