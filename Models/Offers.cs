using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nike_Project_Core.Models
{
    public class Offers
    {
        public int ID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal totalOffer { get; set; }
    }
}
