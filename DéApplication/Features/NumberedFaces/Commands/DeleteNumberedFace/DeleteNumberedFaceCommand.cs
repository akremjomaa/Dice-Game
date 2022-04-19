using MediatR;

namespace DéApplication.Features.NumberedFaces.Commands.DeleteNumberedFace
{
    public class DeleteNumberedFaceCommand:IRequest
    {
        public DeleteNumberedFaceCommand(int id)
        {
            NumberedFaceId = id;
        }

        public int NumberedFaceId { get; set; }
    }
}
