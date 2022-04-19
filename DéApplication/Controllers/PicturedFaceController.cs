using DéApplication.Entities;
using DéApplication.Features.PicturedFaces.Commands.AddPicturedFace;
using DéApplication.Features.PicturedFaces.Commands.DeletePicturedFace;
using DéApplication.Features.PicturedFaces.Commands.UpdatePicturedFace;
using DéApplication.Features.PicturedFaces.Queries.GetPicturedFaceDetail;
using DéApplication.Features.PicturedFaces.Queries.GetPicturedFaceList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DéApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PicturedFaceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PicturedFaceController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpGet("all")]
        public async Task<ActionResult<List<PicturedFace>>> GetAllPicturedFaces()
        {
            var result = await _mediator.Send(new GetPicturedFaceListQuery());
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<PicturedFace>>> GetPicturedFaceById(int id)
        {
            var picturedFaceDetail = new GetPicturedFaceDetailQuery(id);
            return Ok(await _mediator.Send(picturedFaceDetail));

        }
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] AddPicturedFaceCommand addPicturedFaceCommand)
        {
            var id = await _mediator.Send(addPicturedFaceCommand);
            return Ok(id);
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdatePicturedFaceCommand updatePicturedFaceCommand)
        {
            await _mediator.Send(updatePicturedFaceCommand);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletePicturedFaceCommand = new DeletePicturedFaceCommand(id);
            await _mediator.Send(deletePicturedFaceCommand);
            return NoContent();
        }
    }
}
