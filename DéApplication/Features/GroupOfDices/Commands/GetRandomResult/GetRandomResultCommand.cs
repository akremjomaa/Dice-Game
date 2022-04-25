using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Commands.GetRandomResult
{
    public class GetRandomResultCommand:IRequest<ColoredDieDto>
    {
       public int Id { get; set; }
    }
}
