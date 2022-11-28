using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : BaseContent
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}