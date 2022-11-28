using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.SharedContext;
using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
    public class Lecture : BaseContent
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}