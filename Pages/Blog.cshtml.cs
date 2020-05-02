using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunWithBrandt.Models;
using FunWithBrandt.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FunWithBrandt
{
    public class BlogModel : PageModel
    {
        public List<BlogPost> blogPosts;

        public void OnGet()
        {
            blogPosts = DataReader.GetBlog();

        }

    }
}