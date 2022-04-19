using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.PicturedFaces.Queries.GetPicturedFaceDetail
{
    public class GetPicturedFaceDetailQuery:IRequest<PicturedFaceDto>
    {
        public GetPicturedFaceDetailQuery(int picturedFaceId)
        {
            PicturedFaceId = picturedFaceId;
        }

        public int PicturedFaceId { get; set; }
    }
}
