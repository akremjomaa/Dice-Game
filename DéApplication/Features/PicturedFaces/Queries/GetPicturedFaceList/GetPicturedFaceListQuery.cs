using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.PicturedFaces.Queries.GetPicturedFaceList
{
    public class GetPicturedFaceListQuery : IRequest<List<PicturedFaceDto>>
    {
    }
}
