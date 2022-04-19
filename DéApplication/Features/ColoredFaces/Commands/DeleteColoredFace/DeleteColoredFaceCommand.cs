using MediatR;

namespace DéApplication.Features.ColoredFaces.Commands.DeleteColoredFace
{
    public class DeleteColoredFaceCommand : IRequest 
    {
        public DeleteColoredFaceCommand(int id)
        {
            ColoredFaceId = id;
        }
        public int ColoredFaceId { get; set; }
    }
}
