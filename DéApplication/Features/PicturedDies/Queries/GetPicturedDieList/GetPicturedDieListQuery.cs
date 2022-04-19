using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.PicturedDies.Queries.GetPicturedDieList
{
    public class GetPicturedDieListQuery : IRequest<List<PicturedDieDto>>
    {
    }
}
