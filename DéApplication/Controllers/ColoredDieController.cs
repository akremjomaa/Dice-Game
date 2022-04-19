using DéApplication.Features.ColoredDies.Commands.AddColoredDie;
using DéApplication.Features.ColoredDies.Commands.DeleteColoredDie;
using DéApplication.Features.ColoredDies.Commands.SetColoredFaces;
using DéApplication.Features.ColoredDies.Commands.UpdateColoredDie;
using DéApplication.Features.ColoredDies.Queries.GetColoredDieDetail;
using DéApplication.Features.ColoredDies.Queries.GetColoredDieList;
using DéApplication.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DéApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoredDieController : ControllerBase
    {
        private const string EntityName = "coloredDie";
        private readonly ILogger<ColoredDieController> _log;
        private readonly IMediator _mediator;
        public ColoredDieController(ILogger<ColoredDieController> log, IMediator mediator)
        {
            _log = log;
            _mediator = mediator;

        }
        [HttpGet("all")]
        public async Task<ActionResult<List<ColoredDieDto>>> GetAllColoredDies()
        {
            var dtos = await _mediator.Send(new GetColoredDieListQuery());
            return Ok(dtos);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<ColoredDieDto>>> GetById(int id)
        {
            var coloredDieDetail = new GetColoredDieDetailQuery(id);
            return Ok(await _mediator.Send(coloredDieDetail));
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] AddColoredDieCommand addColoredDieCommand)
        {
            _log.LogDebug($"REST request to save {EntityName}  : {addColoredDieCommand}");
            var response = await _mediator.Send(addColoredDieCommand);
            return Ok(response);
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdateColoredDieCommand updateColoredDieCommand)
        {
            await _mediator.Send(updateColoredDieCommand);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var coloredDieToDelete = new DeleteColoredDieCommand(id);
            await _mediator.Send(coloredDieToDelete);
            return NoContent();
        }
        [HttpPost]
        [Route("setColoredFaces")]
        public async Task<ActionResult> setColoredFaces([FromBody] SetColoredFacesCommand coloredFacesCommand)
        {
            _log.LogDebug($"Liste des faces colorées mise à jour avec succès");
            var response = await _mediator.Send(coloredFacesCommand);
            return Ok(response);

        }


    }
}
