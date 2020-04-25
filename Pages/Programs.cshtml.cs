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
    public class ProgramsModel : PageModel
    {
        public void OnGet()
        {

        }

        public bool ShowHubbel;
        public IActionResult OnPost()
        {
            ShowHubbel = true;
            return Page();
        }

        public List<ProgramPost> programPosts = new List<ProgramPost>

        {
            new ProgramPost{
                Title = "Coloy-Coordinate Finder",
                Language = "Python",
                Description = @"Use this to find the (X,Y) coordinates or RGB code for a particular location on your monitor. Just run it and
                                hover your mouse over the area in question. This script runs continuously until interrupted with the control + c keyboard command.
                                You may have issued with dual monitors as I have it crash on me before.",

                Code = DataReader.ReadCodeText("CoordinateColors")
            },

            new ProgramPost{
                Title = "Outlook Email",
                Language = "VBA",
                Description = @"Basic sub to create an outlook email from excel without sending it. Now that I am looking at this though, this should definitely just be a function
                                with the email inputs as parameters.",

                Code = DataReader.ReadCodeText("OutlookEmail")
            },

            new ProgramPost{
                Title = "VBA Utilities",
                Language = "VBA",
                Description = @"Here are a few vba subs and functions which I use all the time. Most don't seem to fancy, but are extremely useful 
                                to reduce repitition adn increase readability in larger programs.",
                Code = DataReader.ReadCodeText("VBA Utils")
            },



        };

    }


}