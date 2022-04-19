using MediatR;

namespace DéApplication.Features.PicturedFaces.Commands.AddPicturedFace
{
    public class AddPicturedFaceCommand:IRequest<int>
    {
        public AddPicturedFaceCommand(string picture)
        {
            Picture = picture;
        }

        public string Picture { get; set; }
    }
}
