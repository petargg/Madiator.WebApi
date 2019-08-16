using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Madiator.WebApi.Entities;
using Madiator.WebApi.Queries.Query;
using MediatR;

namespace Madiator.WebApi.Queries.Handler
{
    public class GetWidgetQueryHandler : IRequestHandler<GetWidgetQuery, Widget>
    {
        public async Task<Widget> Handle(GetWidgetQuery request, CancellationToken cancellationToken)
        {
            var widget = MockWidgetDatabase.Widgets.SingleOrDefault(request.Predicate);
            return await Task.FromResult(widget);
        }
    }
}
