using Madiator.WebApi.Events;
using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Madiator.WebApi.Handlers
{
    public class EmailNotificationHandler : INotificationHandler<LoggerEvent>
    {
        public Task Handle(LoggerEvent notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Notify email with message: {notification.Message}");
            return Task.FromResult(0);
        }
    }
}
