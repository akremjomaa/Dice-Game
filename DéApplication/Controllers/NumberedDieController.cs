using DéApplication.Features.NumberedDies.Commands.AddNumberedDie;
using DéApplication.Features.NumberedDies.Commands.DeleteNumberedDie;
using DéApplication.Features.NumberedDies.Commands.SetNumberedFaces;
using DéApplication.Features.NumberedDies.Commands.UpdateNumberedDie;
using DéApplication.Features.NumberedDies.Queries.GetNumberedDieDetail;
using DéApplication.Features.NumberedDies.Queries.GetNumberedDieList;
using DéApplication.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DéApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberedDieController : ControllerBase
    {
        private const string EntityName = "numberedDie";
        private readonly ILogger<NumberedDieController> _log;
        private readonly IMediator _mediator;
        public NumberedDieController(ILogger<NumberedDieController> log, IMediator mediator)
        {
            _log = log;
            _mediator = mediator;

        }
        [HttpGet("all")]
        public async Task<ActionResult<List<NumberedDieDto>>> GetAllNumberedDies()
        {
            var dtos = await _mediator.Send(new GetNumberedDieListQuery());
            return Ok(dtos);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<NumberedDieDto>>> GetById(int id)
        {
            var numberedDieDetail = new GetNumberedDieDetailQuery(id);
            return Ok(await _mediator.Send(numberedDieDetail));
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] AddNumberedDieCommand addNumberedDieCommand)
        {
            _log.LogDebug($"REST request to save {EntityName}  : {addNumberedDieCommand}");
            var response = await _mediator.Send(addNumberedDieCommand);
            return Ok(response);
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdateNumberedDieCommand updateNumberedDieCommand)
        {
            await _mediator.Send(updateNumberedDieCommand);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var numberedDieToDelete = new DeleteNumberedDieCommand(id);
            await _mediator.Send(numberedDieToDelete);
            return NoContent();
        }
        [HttpPost]
        [Route("setNumberedFaces")]
        public async Task<ActionResult> setNumberedFaces([FromBody] SetNumberedFacesCommand numberedFacesCommand)
        {
            _log.LogDebug($"Liste des faces de dé nombrés mise à jour avec succès");
            var response = await _mediator.Send(numberedFacesCommand);
            return Ok(response);

        }
    }
}
