using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.NumberedFaces.Queries.GetNumberedFaceList
{
    public class GetNumberedFaceListQuery : IRequest<List<NumberedFaceDto>>
    {
    }
}
