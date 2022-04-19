using MediatR;

namespace DéApplication.Features.ColoredFaces.Commands.UpdateColoredFace
{
    public class UpdateColoredFaceCommand : IRequest
    {
        public UpdateColoredFaceCommand()
        {

        }
        public UpdateColoredFaceCommand(int id, string color)
        {
            ColoredFaceId = id;
            Color = color;

        }
        public int ColoredFaceId { get; set; }
        public string Color { get; set; }
    }
}
