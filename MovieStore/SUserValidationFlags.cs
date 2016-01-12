using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore
{
    public struct SUserValidationFlags
    {
        public bool First { get; set; }
        public bool Last { get; set; }
        public bool Address { get; set; }
        public bool Phone { get; set; }
        public bool Email { get; set; }
        public bool CardNumber { get; set; }
    }
}
