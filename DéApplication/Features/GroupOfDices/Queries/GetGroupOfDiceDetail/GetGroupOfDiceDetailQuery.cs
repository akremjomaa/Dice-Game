using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Queries.GetGroupOfDiceDetail
{
    public class GetGroupOfDiceDetailQuery : IRequest<GroupOfDiceDto>
    {
        public GetGroupOfDiceDetailQuery(int id)
        {
            GroupOfDiceId = id;

        }
        public int GroupOfDiceId { get; set; }
    }
}
