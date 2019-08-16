using Madiator.WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Madiator.WebApi.Queries.Query
{
    public class AllWidgetsQuery : IRequest<IEnumerable<Widget>>
    {
    }
}
