using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Queries.GetGroupOfDiceList
{
    public class GetGroupOfDiceListQuery : IRequest<List<GroupOfDiceDto>>
    {
    }
}
