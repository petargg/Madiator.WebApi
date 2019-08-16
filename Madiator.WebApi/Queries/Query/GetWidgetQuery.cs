using Madiator.WebApi.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Madiator.WebApi.Queries.Query
{
    public class GetWidgetQuery : IRequest<Widget>
    {
        public Func<Widget, bool> Predicate { get; private set; }

        public GetWidgetQuery(Func<Widget, bool> predicate)
        {
            this.Predicate = predicate;
        }
    }
}
