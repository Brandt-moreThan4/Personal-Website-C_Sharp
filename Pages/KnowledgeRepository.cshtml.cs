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
    public class KnowledgeRepositoryModel : PageModel
    {
        public List<KnowledgeRecord> knowledgeRecords;
        public List<KnowledgeRecord> displayedKnowledgeRecords;

        //This property is set by the search box input.
        [BindProperty(SupportsGet = true) ]
        public string SearchTerm { get; set; }

        public KnowledgeRepositoryModel()
        {
            knowledgeRecords = DataReader.GetKnowledgeRecords();
        }

        public void OnGet()
        {
            displayedKnowledgeRecords = GetKnowledgeRecordsByKeyWord();
        }

        [BindProperty]
        public KnowledgeRecord KnowledgeId { get; set; }
        public  IActionResult OnPost()
        {            
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
                           k.Description.ToUpper().Contains(searchString) || k.Person_Institution.ToUpper().Contains(searchString)
                           
                           orderby k.Person_Institution
                           select k;

            return records.ToList();

        }

    }
}