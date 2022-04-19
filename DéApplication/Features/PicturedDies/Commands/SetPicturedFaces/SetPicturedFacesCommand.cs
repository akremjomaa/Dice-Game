using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.PicturedDies.Commands.SetPicturedFaces
{
    public class SetPicturedFacesCommand : IRequest
    {
        public ICollection<PicturedDiePictuedFaceDto>? PicturedDiePictuedFaces { get; set; }
    }
}
