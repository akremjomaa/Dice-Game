using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.NumberedDies.Queries.GetNumberedDieDetail
{
    public class GetNumberedDieDetailQuery : IRequest<NumberedDieDto>
    {
        public GetNumberedDieDetailQuery(int dieId)
        {
            DieId = dieId;
        }

        public int DieId { get; set; }
    }
}
