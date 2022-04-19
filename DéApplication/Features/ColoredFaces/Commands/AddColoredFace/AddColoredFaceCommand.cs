using MediatR;

namespace DéApplication.Features.ColoredFaces.Commands.AddColoredFace
{
    public class AddColoredFaceCommand:IRequest<int>
    {
        public AddColoredFaceCommand(string color)
        {
            Color = color;

        }
        public string Color { get; set; }
        
    }
}
