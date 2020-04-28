using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunWithBrandt.Models
{
    public class ProgramPost
    {
        public int ProgramId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string Source { get; set; }
        public string Title { get; set; }

    }
}
