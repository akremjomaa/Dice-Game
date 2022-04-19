using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.ColoredFaces.Queries.GetColoredFaceList
{
    public class GetColoredFaceListQuery : IRequest<List<ColoredFaceDto>>
    {
    }
}
