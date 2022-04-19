using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.NumberedDies.Commands.SetNumberedFaces
{
    public class SetNumberedFacesCommand : IRequest
    {
        public ICollection<NumberedDieNumberedFaceDto>? NumberedDieNumberedFaces { get; set; }
    }
}
