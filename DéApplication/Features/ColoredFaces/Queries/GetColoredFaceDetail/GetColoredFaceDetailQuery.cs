using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.ColoredFaces.Queries.GetColoredFaceDetail
{
    public class GetColoredFaceDetailQuery : IRequest<ColoredFaceDto>
    {
        public GetColoredFaceDetailQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
