using MediatR;

namespace DéApplication.Features.PicturedFaces.Commands.UpdatePicturedFace
{
    public class UpdatePicturedFaceCommand : IRequest
    {
        public UpdatePicturedFaceCommand()
        {

        }
        public UpdatePicturedFaceCommand(int id , string picture)
        {
            PicturedFaceId = id;
            Picture = picture;

        }
        public int PicturedFaceId { get; set; }
        public string Picture { get; set; }
    }
}
