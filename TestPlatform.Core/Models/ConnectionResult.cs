using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlatform.Core.Models
{
    public class ConnectionResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Alias { get; set; }
        public byte[]  Raw { get; set; }
    }
}
