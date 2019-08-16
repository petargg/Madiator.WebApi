using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Madiator.WebApi.Events
{
    public class LoggerEvent : INotification
    {
        public string Message { get; private set; }

        public LoggerEvent(string message)
        {
            this.Message = message;
        }
    }
}
