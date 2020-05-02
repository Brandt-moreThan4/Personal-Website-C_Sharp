using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using OfficeOpenXml;
using System.Linq;
using static FunWithBrandt.Models.Data.EPPlusUtils;

namespace FunWithBrandt.Models.Data
{
    public class DataReader
    {

        public static List<KnowledgeRecord> GetKnowledge()
        {
            var knowledgeRecords = new List<KnowledgeRecord>(); KnowledgeRecord knowledgeRec;
            var dbPath = Directory.GetCurrentDirectory() + @"\wwwroot\Data\websiteDB.xlsx";

            if (File.Exists(dbPath))
            {
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                FileInfo fi = new FileInfo(dbPath);

                using (ExcelPackage excelPack = new ExcelPackage(fi))
                {
                    var knowledgeWs = excelPack.Workbook.Worksheets["Knowledge"];
                    var lastRow = GetLastRow(knowledgeWs);
                    for (int i = 2; i <= lastRow; i++)
                    {
                        knowledgeRec = new KnowledgeRecord();
                        knowledgeRec.KnowledgeId = Convert.ToInt32(knowledgeWs.Cells[i, 1].Text);
                        knowledgeRec.Person_Institution = knowledgeWs.Cells[i, 2].Text;
                        knowledgeRec.Description = knowledgeWs.Cells[i, 3].Text;
                        knowledgeRec.Source = knowledgeWs.Cells[i, 4].Text;
                        knowledgeRec.Keywords = knowledgeWs.Cells[i, 5].Text;
                        knowledgeRecords.Add(knowledgeRec);
                    }
                }
            }
            return knowledgeRecords;
        }

        public static List<Book> GetBooks()
        {
            var books = new List<Book>(); Book book;
            var dbPath = Directory.GetCurrentDirectory() + @"\wwwroot\Data\websiteDB.xlsx";

            if (File.Exists(dbPath))
            {
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                FileInfo fi = new FileInfo(dbPath);

                using (ExcelPackage excelPack = new ExcelPackage(fi))
                {
                    var bookWs = excelPack.Workbook.Worksheets["Books"];
                    var lastRow = GetLastRow(bookWs);
                    for (int i = 2; i <= lastRow; i++)
                    {
                        book = new Book();
                        book.BookId = Convert.ToInt32(bookWs.Cells[i, 1].Text);
                        book.Title = bookWs.Cells[i, 2].Text;
                        book.Author = bookWs.Cells[i, 3].Text;
                        book.CoverImageName = bookWs.Cells[i, 4].Text;
                        book.CoverDescription = bookWs.Cells[i, 5].Text;
                        book.Content = bookWs.Cells[i, 6].Text;
                        books.Add(book);                          
                    }
                }
            }
            return books;
        }

        public static List<ProgramPost> GetPrograms()
        {
            var programs = new List<ProgramPost>(); ProgramPost program;
            var dbPath = Directory.GetCurrentDirectory() + @"\wwwroot\Data\websiteDB.xlsx";

            if (File.Exists(dbPath))
            {
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                FileInfo fi = new FileInfo(dbPath);

                using (ExcelPackage excelPack = new ExcelPackage(fi))
                {
                    var programWs = excelPack.Workbook.Worksheets["Programs"];
                    var lastRow = GetLastRow(programWs);
                    for (int i = 2; i <= lastRow; i++)
                    {
                        program = new ProgramPost();
                        program.ProgramId = Convert.ToInt32(programWs.Cells[i, 1].Text);
                        program.Code = programWs.Cells[i, 2].Text;
                        program.Description = programWs.Cells[i, 3].Text;
                        program.Language = programWs.Cells[i, 4].Text;
                        program.Source = programWs.Cells[i, 5].Text;
                        program.Title = programWs.Cells[i, 6].Text;
                        programs.Add(program);
                    }
                }
            }
            return programs;
        }

        public static List<BlogPost> GetBlog()
        {
            var blogPosts = new List<BlogPost>(); BlogPost blogPost;
            var dbPath = Directory.GetCurrentDirectory() + @"\wwwroot\Data\websiteDB.xlsx";

            if (File.Exists(dbPath))
            {
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                FileInfo fi = new FileInfo(dbPath);

                using (ExcelPackage excelPack = new ExcelPackage(fi))
                {
                    var blogWs = excelPack.Workbook.Worksheets["Blog"];
                    var lastRow = GetLastRow(blogWs);
                    for (int i = 2; i <= lastRow; i++)
                    {
                        blogPost = new BlogPost();
                        blogPost.BlodId = Convert.ToInt32(blogWs.Cells[i, 1].Text);
                        blogPost.Date = DateTime.Parse(blogWs.Cells[i, 2].Text);
                        blogPost.Title = blogWs.Cells[i, 3].Text;
                        blogPost.Content = ParseBlogText(blogWs.Cells[i, 4].Text);
                        blogPosts.Add(blogPost);
                    }
                }
                
                blogPosts = blogPosts.OrderByDescending(b => b.Date).ToList();


            }
            return blogPosts;
        }

        private static List<string> ParseBlogText(string text)
        {
            List<string> blogChunks = new List<string>();
            string[] splitText= text.Split("\n");

            foreach (var line in splitText)
            {
                blogChunks.Add(line);
            }


            return blogChunks;
        }

    }
    
}
