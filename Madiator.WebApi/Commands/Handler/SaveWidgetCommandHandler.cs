using Madiator.WebApi.Commands.Command;
using Madiator.WebApi.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Madiator.WebApi.Commands.Handler
{
    public class SaveWidgetCommandHandler : IRequestHandler<SaveWidgetCommand, CommandResponse>
    {
        public async Task<CommandResponse> Handle(SaveWidgetCommand request, CancellationToken cancellationToken)
        {
            var response = new CommandResponse() { Success = false };

            try
            {
                var widget = MockWidgetDatabase.Widgets.SingleOrDefault(x => x.Id == request.Widget.Id);

                if (widget == null)
                {
                    //Save
                    widget = new Widget()
                    {
                        Id = MockWidgetDatabase.UniqueWidgetId,
                        Name = request.Widget.Name,
                        Shape = request.Widget.Shape
                    };
                    MockWidgetDatabase.UniqueWidgetId++;
                    MockWidgetDatabase.Widgets.Add(widget);

                    response.Id = widget.Id;
                    response.Success = true;
                    response.StatusCode = StatusCodes.Status201Created;
                }
                else
                {
                    response.StatusCode = StatusCodes.Status400BadRequest;
                    response.Message = $"Widget with id {request.Widget.Id} already exist.";
                }
            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
                response.StatusCode = StatusCodes.Status500InternalServerError;
            }

            return await Task.FromResult(response);
        }
    }
}
