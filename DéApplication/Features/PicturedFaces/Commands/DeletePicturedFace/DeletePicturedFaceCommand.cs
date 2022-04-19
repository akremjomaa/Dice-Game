using MediatR;

namespace DéApplication.Features.PicturedFaces.Commands.DeletePicturedFace
{
    public class DeletePicturedFaceCommand : IRequest
    {
        public DeletePicturedFaceCommand(int picturedFaceId)
        {
            PicturedFaceId = picturedFaceId;
        }

        public int PicturedFaceId { get; set; }

    }
}
