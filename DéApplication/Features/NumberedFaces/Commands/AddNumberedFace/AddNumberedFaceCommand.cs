using MediatR;

namespace DéApplication.Features.NumberedFaces.Commands.AddNumberedFace
{
    public class AddNumberedFaceCommand : IRequest<int>
    {
        public AddNumberedFaceCommand(string faceNumber)
        {
            FaceNumber = faceNumber;
        }

        public string FaceNumber { get; set; }
    }
}
