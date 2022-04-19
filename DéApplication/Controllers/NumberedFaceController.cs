using DéApplication.Entities;
using DéApplication.Features.NumberedFaces.Commands.AddNumberedFace;
using DéApplication.Features.NumberedFaces.Commands.DeleteNumberedFace;
using DéApplication.Features.NumberedFaces.Commands.UpdateNumberedFace;
using DéApplication.Features.NumberedFaces.Queries.GetNumberedFaceDetail;
using DéApplication.Features.NumberedFaces.Queries.GetNumberedFaceList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DéApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberedFaceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public NumberedFaceController(IMediator mediator)
        {
                _mediator = mediator;

        }
        [HttpGet("all")]
        public async Task<ActionResult<List<NumberedFace>>> GetAllNumberedFaces()
        {
            var result = await _mediator.Send(new GetNumberedFaceListQuery());
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<NumberedFace>>> GetNumberedFaceById(int id)
        {
            var numberedFaceDetail = new GetNumberedFaceDetailQuery(id);
            return Ok(await _mediator.Send(numberedFaceDetail));

        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] AddNumberedFaceCommand createNumberedFaceCommand)
        {
            var id = await _mediator.Send(createNumberedFaceCommand);
            return Ok(id);
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdateNumberedFaceCommand updateNumberedFaceCommand)
        {
            await _mediator.Send(updateNumberedFaceCommand);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteNumberedFaceCommand = new DeleteNumberedFaceCommand(id);
            await _mediator.Send(deleteNumberedFaceCommand);
            return NoContent();
        }
    }
}
