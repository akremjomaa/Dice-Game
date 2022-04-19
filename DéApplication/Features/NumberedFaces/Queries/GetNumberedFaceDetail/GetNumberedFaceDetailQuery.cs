using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.NumberedFaces.Queries.GetNumberedFaceDetail
{
    public class GetNumberedFaceDetailQuery:IRequest<NumberedFaceDto>
    {
        public GetNumberedFaceDetailQuery(int id)
        {
            Id = id;

        }
        public int Id { get; set; }
    }
}
