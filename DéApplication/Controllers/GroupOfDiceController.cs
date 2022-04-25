using DéApplication.DbContexts;
using DéApplication.Entities;
using DéApplication.Features.GroupOfDices.Commands.AddGroupOfDice;
using DéApplication.Features.GroupOfDices.Commands.DeleteGroupOfDice;
using DéApplication.Features.GroupOfDices.Commands.SetDiceToGroupOfDice;
using DéApplication.Features.GroupOfDices.Commands.UpdateGroupOfDice;
using DéApplication.Features.GroupOfDices.Queries.GetGroupOfDiceDetail;
using DéApplication.Features.GroupOfDices.Queries.GetGroupOfDiceList;
using DéApplication.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DéApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupOfDiceController : ControllerBase
    {
        private const string EntityName = "groupOfDice";
        private readonly ILogger<GroupOfDiceController> _log;
        private readonly IMediator _mediator;
        private readonly DiceContext _diceContext;
        public GroupOfDiceController(ILogger<GroupOfDiceController> logger, IMediator mediator, DiceContext diceContext)
        {
            _log = logger;
            _mediator = mediator;
            _diceContext = diceContext;

        }
        [HttpGet("all")]
        public async Task<ActionResult<List<GroupOfDiceDto>>> GetAllGroupsOfDice()
        {
            var dtos = await _mediator.Send(new GetGroupOfDiceListQuery());
            return Ok(dtos);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<GroupOfDiceDto>>> GetById(int id)
        {
            var groupOfDiceDetail = new GetGroupOfDiceDetailQuery(id);
            return Ok(await _mediator.Send(groupOfDiceDetail));
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] AddGroupOfDiceCommand addGroupOfDiceCommand)
        {
            _log.LogDebug($"REST request to save {EntityName}  : {addGroupOfDiceCommand}");
            var response = await _mediator.Send(addGroupOfDiceCommand);
            return Ok(response);
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdateGroupOfDiceCommand updateGroupOfDiceCommand)
        {
            await _mediator.Send(updateGroupOfDiceCommand);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var groupOfDiceToDelete = new DeleteGroupOfDiceCommand(id);
            await _mediator.Send(groupOfDiceToDelete);
            return NoContent();
        }
        [HttpPost]
        [Route("setdiesToGroupOfDice")]
        public async Task<ActionResult> setdiesToGroupOfDice([FromBody] SetDiceToGroupOfDiceCommand setGroupOfDiceCommand)
        {
            _log.LogDebug($"Liste des groupes de dés mise à jour avec succès");
            var response = await _mediator.Send(setGroupOfDiceCommand);
            return Ok(response);

        }
       /* [HttpGet("type")]
        public async Task<IActionResult>type(int dieId)
        { 
            var colored = 
            var dietmp =await _diceContext.Dies.FirstOrDefaultAsync();
            var xxx =  dietmp.GetType().Name;
            return Ok(xxx);
        }*/

       
    }
}
