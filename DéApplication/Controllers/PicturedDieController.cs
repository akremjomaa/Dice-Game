using DéApplication.Features.PicturedDies.Commands.AddPicturedDie;
using DéApplication.Features.PicturedDies.Commands.DeletePicturedDie;
using DéApplication.Features.PicturedDies.Commands.SetPicturedFaces;
using DéApplication.Features.PicturedDies.Commands.UpdatePicturedDie;
using DéApplication.Features.PicturedDies.Queries.GetPicturedDieDetail;
using DéApplication.Features.PicturedDies.Queries.GetPicturedDieList;
using DéApplication.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DéApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicturedDieController : ControllerBase
    {
        private const string EntityName = "picturedDie";
        private readonly ILogger<PicturedDieController> _log;
        private readonly IMediator _mediator;
        public PicturedDieController(ILogger<PicturedDieController> log , IMediator mediator)
        {
            _log = log;
            _mediator = mediator;

        }
        [HttpGet("all")]
        public async Task<ActionResult<List<PicturedDieDto>>> GetAllPicturedDies()
        {
            var dtos = await _mediator.Send(new GetPicturedDieListQuery());
            return Ok(dtos);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<PicturedDieDto>>> GetById(int id)
        {
            var picturedDieDetail = new GetPicturedDieDetailQuery(id);
            return Ok(await _mediator.Send(picturedDieDetail));
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] AddPicturedDieCommand addPicturedDieCommand)
        {
            _log.LogDebug($"REST request to save {EntityName}  : {addPicturedDieCommand}");
            var response = await _mediator.Send(addPicturedDieCommand);
            return Ok(response);
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdatePicturedDieCommand updatePicturedDieCommand)
        {
            await _mediator.Send(updatePicturedDieCommand);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var picturedDieToDelete = new DeletePicturedDieCommand(id);
            await _mediator.Send(picturedDieToDelete);
            return NoContent();
        }
        [HttpPost]
        [Route("setPicturedFaces")]
        public async Task<ActionResult> setNumberedFaces([FromBody] SetPicturedFacesCommand picturedFacesCommand)
        {
            _log.LogDebug($"Liste des faces de dé d'images mise à jour avec succès");
            var response = await _mediator.Send(picturedFacesCommand);
            return Ok(response);

        }
    }
}
