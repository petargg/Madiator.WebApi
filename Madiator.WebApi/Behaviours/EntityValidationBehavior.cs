using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Madiator.WebApi.Commands;
using MediatR;

namespace Madiator.WebApi.Behaviours
{
    public class EntityValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            if(request is ISaveWidget)
            {
                Debug.WriteLine("This is save");
            }

            Debug.WriteLine("Before");
            var response = await next();
            Debug.WriteLine("After");

            return response;
        }
    }
}
