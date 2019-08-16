using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Madiator.WebApi.Entities
{
    public class CommandResponse
    {
        public int Id { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

        public int StatusCode { get; set; }
    }
}
