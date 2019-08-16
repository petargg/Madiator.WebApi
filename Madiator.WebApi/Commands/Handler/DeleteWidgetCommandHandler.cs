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
    public class DeleteWidgetCommandHandler : IRequestHandler<DeleteWidgetCommand, CommandResponse>
    {
        public async Task<CommandResponse> Handle(DeleteWidgetCommand request, CancellationToken cancellationToken)
        {
            var response = new CommandResponse() { Success = false };

            var widget = MockWidgetDatabase.Widgets.SingleOrDefault(x => x.Id == request.Id);

            if(widget == null)
            {
                response.StatusCode = StatusCodes.Status404NotFound;
                return await Task.FromResult(response);
            }

            response.Id = widget.Id;

            MockWidgetDatabase.Widgets.Remove(widget);
            response.Success = true;
            response.StatusCode = StatusCodes.Status204NoContent;

            return await Task.FromResult(response);
        }
    }
}
