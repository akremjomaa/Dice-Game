using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.ColoredDies.Queries.GetColoredDieDetail
{
    public class GetColoredDieDetailQuery:IRequest<ColoredDieDto>
    {
        public GetColoredDieDetailQuery(int id)
        {
            DieId = id;

        }
        public int DieId { get; set; }
    }
}
