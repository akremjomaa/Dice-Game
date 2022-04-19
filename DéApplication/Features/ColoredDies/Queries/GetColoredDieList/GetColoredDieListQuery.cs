using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.ColoredDies.Queries.GetColoredDieList
{
    public class GetColoredDieListQuery:IRequest<List<ColoredDieDto>>
    {
    }
}
