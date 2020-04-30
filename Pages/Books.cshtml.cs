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
    public class BooksModel : PageModel
    {
        public bool ShowHubbel;
        public List<Book> Books;
        public int RowCount
        { 
            get
            {
                if (this.Books.Count == 0 )
                {
                    return 0;
                }
                
                var rowsNeeded = Convert.ToInt32(Math.Ceiling((double)Books.Count / 4));

                return rowsNeeded;
            }
        }

        public void OnGet()
        {
            this.Books = GetBooks();
        }


        public IActionResult OnPost()
        {
            ShowHubbel = true;
            return Page();
        }



        public List<Book> GetBooks()
        {
            List<Book> books = DataReader.GetBooks();
            return books;
        }


    }



}