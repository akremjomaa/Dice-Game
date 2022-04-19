using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.ColoredDies.Commands.SetColoredFaces
{
    public class SetColoredFacesCommand : IRequest
    {
        public ICollection<ColoredDieColoredFaceDto>? ColoredDieColoredFaces { get; set; }
    }
}
