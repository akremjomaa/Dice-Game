using DéApplication.Models;
using MediatR;

namespace DéApplication.Features.GroupOfDices.Commands.SetDiceToGroupOfDice
{
    public class SetDiceToGroupOfDiceCommand : IRequest
    {
        public int GroupOfDiceId { get; set; }
        public ICollection<DieGroupOfDiceDto>? DieGroupOfDice { get; set; }

    }
}
