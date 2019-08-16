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
    public class UpdateWidgetCommandHandler : IRequestHandler<UpdateWidgetCommand, CommandResponse>
    {
        public async Task<CommandResponse> Handle(UpdateWidgetCommand request, CancellationToken cancellationToken)
        {
            var response = new CommandResponse() { Success = false };

            try
            {
                var widget = MockWidgetDatabase.Widgets.SingleOrDefault(x => x.Id == request.Widget.Id);

                if (widget == null)
                {
                    response.StatusCode = StatusCodes.Status404NotFound;
                    response.Message = $"Widget with id {request.Widget.Id} is not found.";
                }
                else
                {
                    //Update
                    widget.Name = request.Widget.Name;
                    widget.Shape = request.Widget.Shape;

                    response.StatusCode = StatusCodes.Status204NoContent;
                    response.Id = widget.Id;
                    response.Success = true;
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.StatusCode = StatusCodes.Status500InternalServerError;
            }

            return await Task.FromResult(response);
        }
    }
}
