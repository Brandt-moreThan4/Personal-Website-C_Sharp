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
        //I'm really confused as to why I have to fully qualify the program post type with namespace
        public List<FunWithBrandt.Models.ProgramPost> programPosts;

        public ProgramsModel()
        {
            programPosts = DataReader.GetPrograms();
        }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            return Page();
        }


    }


}