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
            blogPosts = GetBlogData();

        }

        //Desperately want a better way to do this.

        public List<BlogPost> GetBlogData()
        {
            var allPosts = new List<BlogPost>();


            allPosts.Add(new BlogPost()
            {
                Date = "March 3, 2020",
                Title = "Corporate Profits",
                Content = DataReader.ReadBlogText("CorporateProfits_2020-3-2")
            });

            allPosts.Add(new BlogPost()
            {
                Date = "February 9, 2020",
                Title = "Manager Style",
                Content = DataReader.ReadBlogText("ManagerStyle_2020-2-9")
            });

            allPosts.Add(new BlogPost()
            {
                Date = "February 2, 2020",
                Title = "Investment Execution-2",
                Content = DataReader.ReadBlogText("InvestmentExecution-2_2020-2-2")
            });

            allPosts.Add(new BlogPost()
            {
                Date = "February 1, 2020",
                Title = "Investment Execution",
                Content = DataReader.ReadBlogText("InvestmentExecution_2020-2-1")
            });

            allPosts.Add(new BlogPost()
            {
                Date = "September 29, 2019",
                Title = "Friends in WW I",
                Content = DataReader.ReadBlogText("WW1_2019-9-29")
            });

            return allPosts;
        }



    }
}