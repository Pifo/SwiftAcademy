using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore
{
    public class CRentWithoutCharges
    {
        public int RentId { get; set; }
        public DateTime DueDate { get; set; }
        public int UserId { get; set; }
        public int UserCardNumber { get; set; }
        public string MovieTitle { get; set; }
    }
}
