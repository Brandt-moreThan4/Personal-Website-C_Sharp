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
        public List<KnowledgeRecord> displayedKnowledgeRecords;
        public bool ShowHubbel;

        [BindProperty(SupportsGet = true) ]
        public string SearchTerm { get; set; }

        public KnowledgeRepositoryModel()
        {
            knowledgeRecords = DataReader.KnowledgeRead();
        }

        public void OnGet()
        {
            displayedKnowledgeRecords = GetKnowledgeRecordsByKeyWord();
        }

        public  IActionResult OnPost()
        {
            ShowHubbel = true;
            displayedKnowledgeRecords = GetKnowledgeRecordsByKeyWord();
            return Page();
        }

        public List<KnowledgeRecord> GetKnowledgeRecordsByKeyWord()
        {
            var searchString = this.SearchTerm;

            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToUpper();
            }
          
            var  records = from k in knowledgeRecords
                           where string.IsNullOrEmpty(searchString) || k.Keywords.ToUpper().Contains(searchString) ||
                           k.Description.ToUpper().Contains(searchString) || k.Person.ToUpper().Contains(searchString)
                           
                           orderby k.Person
                           select k;

            return records.ToList();

        }

    }
}