using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunWithBrandt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FunWithBrandt
{
    public class KnowledgeRepositoryModel : PageModel
    {
        public List<KnowledgeRecord> knowledgeRecords;
        public bool ShowHubbel;

        public void OnGet()
        {
            knowledgeRecords = DataReader.KnowledgeRead();
        }

        public  IActionResult OnPost()
        {
            ShowHubbel = true;
            var haha  = ShowHubbel ? "lol" : "hH";
            knowledgeRecords = DataReader.KnowledgeRead();
            return Page();
        }

    }
}