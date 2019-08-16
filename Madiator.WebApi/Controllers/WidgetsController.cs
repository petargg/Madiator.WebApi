using System.Threading.Tasks;
using Madiator.WebApi.Commands.Command;
using Madiator.WebApi.Entities;
using Madiator.WebApi.Queries.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Madiator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WidgetsController : ControllerBase
    {
        private readonly IMediator mediator;

        public WidgetsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var widgets = await this.mediator.Send(new AllWidgetsQuery());
            return Ok(widgets);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var widget = await this.mediator.Send(new GetWidgetQuery(x => x.Id == id));

            if(widget == null)
            {
                return NotFound();
            }

            return Ok(widget);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Widget item)
        {
            var response = await this.mediator.Send(new SaveWidgetCommand(item));

            if (response.Success)
            {
                item.Id = response.Id;
                return StatusCode(response.StatusCode, item);
            }

            return StatusCode(response.StatusCode, response.Message);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Widget item)
        {
            var response = await this.mediator.Send(new UpdateWidgetCommand(item));

            if (response.Success)
            {
                return StatusCode(response.StatusCode, item);
            }

            return StatusCode(response.StatusCode, response.Message);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await this.mediator.Send(new DeleteWidgetCommand(id));

            if (response.Success)
            {
                return StatusCode(response.StatusCode);
            }

            return StatusCode(response.StatusCode, response.Message);
        }
    }
}
