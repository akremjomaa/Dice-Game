using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.NumberedDies.Queries.GetNumberedDieList
{
    public class GetNumberedDieListQuery : IRequest<List<NumberedDieDto>>
    {
    }
}
