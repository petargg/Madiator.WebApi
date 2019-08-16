using Madiator.WebApi.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Madiator.WebApi.Handlers
{
    public class DBNotificationHandler : INotificationHandler<LoggerEvent>
    {
        public Task Handle(LoggerEvent notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Notify db with message: {notification.Message}");
            return Task.FromResult(0);
        }
    }
}
