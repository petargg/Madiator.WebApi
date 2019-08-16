using Madiator.WebApi.Entities;
using MediatR;

namespace Madiator.WebApi.Commands.Command
{
    public class SaveWidgetCommand : IRequest<CommandResponse>, ISaveWidget
    {
        public Widget Widget { get; private set; }

        public SaveWidgetCommand(Widget widget)
        {
            this.Widget = widget;
        }
    }
}
