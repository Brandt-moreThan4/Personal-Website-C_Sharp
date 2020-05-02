using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunWithBrandt.Models
{
    public class BlogPost
    {
        public int BlodId { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public List<string> Content { get; set; }
        public string ContentFileName { get; set; }
        public List<string> Comments { get; set; }
        public int PostId { get; set; }
    }
}
