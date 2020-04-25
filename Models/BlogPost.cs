using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunWithBrandt.Models
{
    public class BlogPost
    {
        public int BlodId { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public List<string> Content { get; set; }
        public string ContentFileName { get; set; }
    }
}
