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
    public class AllWidgetsQueryHandler : IRequestHandler<AllWidgetsQuery, IEnumerable<Widget>>
    {
        public async Task<IEnumerable<Widget>> Handle(AllWidgetsQuery request, CancellationToken cancellationToken)
        {
            var widgets = MockWidgetDatabase.Widgets.OrderBy(x => x.Id);
            return await Task.FromResult(widgets);
        }
    }
}
