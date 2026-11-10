using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPlatform.Core.Abstractions;

namespace TestPlatform.Core.Models
{
    internal class ActionFactory
    {
        private readonly Dictionary<string, IActionHandler> _handlers;

        public ActionFactory()
        {
            _handlers = new Dictionary<string, IActionHandler>(StringComparer.OrdinalIgnoreCase);
        }
    }
}
