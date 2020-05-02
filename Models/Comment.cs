using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunWithBrandt.Models
{
    public class Comment
    {
        public string CommentId { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public string PostId { get; set; }
    }
}
