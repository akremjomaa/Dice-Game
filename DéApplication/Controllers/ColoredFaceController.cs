using DéApplication.Entities;
using DéApplication.Features.ColoredFaces.Commands.AddColoredFace;
using DéApplication.Features.ColoredFaces.Commands.DeleteColoredFace;
using DéApplication.Features.ColoredFaces.Commands.UpdateColoredFace;
using DéApplication.Features.ColoredFaces.Queries.GetColoredFaceDetail;
using DéApplication.Features.ColoredFaces.Queries.GetColoredFaceList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DéApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoredFaceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ColoredFaceController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpGet("all")]
        public async Task<ActionResult<List<ColoredFace>>> GetAllColoredFaces()
        {
            var result = await _mediator.Send(new GetColoredFaceListQuery());
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<ColoredFace>>> GetColoredFaceById(int id)
        {
            var coloredFaceDetail = new GetColoredFaceDetailQuery(id);
            return Ok(await _mediator.Send(coloredFaceDetail));

        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] AddColoredFaceCommand createColoredFaceCommand)
        {
            var id = await _mediator.Send(createColoredFaceCommand);
            return Ok(id);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteColoredFaceCommand = new DeleteColoredFaceCommand(id);
            await _mediator.Send(deleteColoredFaceCommand);
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdateColoredFaceCommand updateColoredFaceCommand)
        {
            await _mediator.Send(updateColoredFaceCommand);
            return NoContent();
        }
    }
}
