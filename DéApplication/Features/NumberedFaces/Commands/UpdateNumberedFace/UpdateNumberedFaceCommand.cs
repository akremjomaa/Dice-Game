using MediatR;

namespace DéApplication.Features.NumberedFaces.Commands.UpdateNumberedFace
{
    public class UpdateNumberedFaceCommand : IRequest
    {
        public UpdateNumberedFaceCommand()
        {

        }
        public UpdateNumberedFaceCommand(int id,int faceNumber )
        {
            NumberedFaceId = id;
            FaceNumber = faceNumber;

        }
        public int NumberedFaceId { get; set; }
        public int FaceNumber { get; set; }
    }
}
