using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore
{
    public class CChargeViewer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int? OverdueDays { get; set; }
        public decimal? Charge { get; set; }
    }
}
