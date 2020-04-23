using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunWithBrandt.Models
{
    public class Book:Post
    {
        public string CoverDescription { get; set; }
        public string CoverImageName { get; set; }
    }
}
