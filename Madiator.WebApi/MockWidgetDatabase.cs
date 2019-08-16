using Madiator.WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Madiator.WebApi
{
    public static class MockWidgetDatabase
    {
        public static IList<Widget> Widgets { get; }
        public static int UniqueWidgetId = 4;
        static MockWidgetDatabase()
        {
            Widgets = new List<Widget>()
            {
                new Widget {Id = 1, Name = "Widget 1", Shape = "Shape 1"},
                new Widget {Id = 2, Name = "Widget 2", Shape = "Shape 2"},
                new Widget {Id = 3, Name = "Widget 3", Shape = "Shape 3"}
            };
        }
    }
}
