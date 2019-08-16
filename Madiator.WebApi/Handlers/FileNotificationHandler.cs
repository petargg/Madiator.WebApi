using Madiator.WebApi.Events;
using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Madiator.WebApi.Handlers
{
    public class FileNotificationHandler : INotificationHandler<LoggerEvent>
    {
        public Task Handle(LoggerEvent notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Notify file with message: {notification.Message}");
            return Task.FromResult(0);
        }
    }
}
