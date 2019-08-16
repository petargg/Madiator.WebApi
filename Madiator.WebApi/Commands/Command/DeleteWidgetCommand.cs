using Madiator.WebApi.Entities;
using MediatR;

namespace Madiator.WebApi.Commands.Command
{
    public class DeleteWidgetCommand : IRequest<CommandResponse>
    {
        public int Id { get; private set; }

        public DeleteWidgetCommand(int id)
        {
            this.Id = id;
        }
    }
}
