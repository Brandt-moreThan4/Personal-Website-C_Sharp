using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunWithBrandt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FunWithBrandt
{
    public class BlogModel : PageModel
    {
        public List<BlogPost> blogPosts;

        public void OnGet()
        {
            blogPosts = GetBlogData();

        }

        //Desperately want a better way to do this.

        public List<BlogPost> GetBlogData()
        {
            var allPosts = new List<BlogPost>();


            allPosts.Add(new BlogPost()
            {
                Date = "February 9, 2020",
                Title = "Corporate Profits",
                Content = DataReader.ReadBlogText("CorporateProfits")
            });

            allPosts.Add(new BlogPost()
            {
                Date = "February 9, 2020",
                Title = "Manager Style",
                Content = DataReader.ReadBlogText("Manager Style")
            });

            allPosts.Add(new BlogPost()
            {
                Date = "February 1, 2020",
                Title = "Investment Execution",
                Content = DataReader.ReadBlogText("Investment Execution")
            });

            allPosts.Add(new BlogPost()
            {
                Date = "September 29, 2019",
                Title = "Friends in WW I",
                Content = DataReader.ReadBlogText("WW1")
            });

            return allPosts;
        }



    }
}