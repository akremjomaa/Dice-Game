using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.PicturedDies.Queries.GetPicturedDieDetail
{
    public class GetPicturedDieDetailQuery:IRequest<PicturedDieDto>
    {
        public GetPicturedDieDetailQuery(int dieId)
        {
            DieId = dieId;
        }

        public int DieId { get; set; }
    }
}
