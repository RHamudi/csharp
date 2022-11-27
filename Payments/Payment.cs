using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payments
{
    public class Payment
    {
        public int Id { get; set; }
        public Payment(int id)
        {
            Id = id;
        }
    }
}