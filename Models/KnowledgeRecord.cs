using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunWithBrandt.Models
{
    public class KnowledgeRecord
    {
        public int KnowledgeId { get; set; }
        public string Person_Institution { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public string Keywords { get; set; }
    }
}
