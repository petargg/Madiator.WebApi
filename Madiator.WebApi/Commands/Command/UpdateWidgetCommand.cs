using Madiator.WebApi.Entities;
using MediatR;

namespace Madiator.WebApi.Commands.Command
{
    public class UpdateWidgetCommand : IRequest<CommandResponse>
    {
        public Widget Widget { get; private set; }

        public UpdateWidgetCommand(Widget widget)
        {
            this.Widget = widget;
        }
    }
}
