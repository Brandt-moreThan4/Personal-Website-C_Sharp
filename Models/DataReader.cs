using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Diagnostics;

namespace FunWithBrandt.Models
{
    public class DataReader
    {
        public static List<KnowledgeRecord> KnowledgeRead()
        {

            var records = new List<KnowledgeRecord>();
            var path = Directory.GetCurrentDirectory() + @"\wwwroot\Data\KnowledgeRepoTable.csv";
            var line = string.Empty; string [] splitString;
            KnowledgeRecord record;

            if (File.Exists(path))
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    line = sw.ReadLine();
                    while (line != null)
                    {
                        splitString = line.Split(",");
                        record = new KnowledgeRecord();                        
                        record.Person = splitString[0];
                        record.Institution = splitString[1];
                        record.Description = splitString[2];
                        record.Source = splitString[3];
                        record.Keywords = splitString[4];
                        records.Add(record);
                        line = sw.ReadLine();
                    }                    
                }
            }

            return records;

        }

        public static List<Book> ReadBooks()
        {
            var books = new List<Book>(); Book book; var line = string.Empty; string[] splitString;
            var path = Directory.GetCurrentDirectory() + @"\wwwroot\Data\BooksDB.csv";
            
            

            if (File.Exists(path))
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    line = sw.ReadLine();
                    while (line != null)
                    {
                        splitString = line.Split(",");
                        book = new Book();
                        book.BookId = Convert.ToInt32(splitString[0]);
                        book.Title = splitString[1];
                        book.CoverImageName = splitString[2];
                        book.CoverDescription = splitString[3];
                        book.LongDescription = splitString[4];
                        books.Add(book);
                        line = sw.ReadLine();
                    }
                }
            }
            return books;
        }

        public static List<string> ReadBlogText(string fileName)
        {
            var blogContentPath = GetRootPath() + @"BlogContent\" + fileName + ".txt";

            var content = new List<string>();
            var line = string.Empty;

            if (File.Exists(blogContentPath))
            {
                using (StreamReader sw = new StreamReader(blogContentPath))
                {
                    line = sw.ReadLine();
                    while (line != null)
                    {
                        content.Add(line);
                        line = sw.ReadLine();
                    }


                }

            }
            else
            {
                Debug.Print("File Does not exist");
            }
            return content;


            throw new NotImplementedException();
        }

        public static string ReadCodeText(string fileName)
        {
            string tempString = string.Empty;
            var codeTxtPath = GetRootPath() + @"ProgramText\" + fileName + ".txt";
            
            var line = string.Empty;
            if (File.Exists(codeTxtPath))
            {
                using (StreamReader sw = new StreamReader(codeTxtPath))
                {
                    tempString = sw.ReadToEnd();

                }

            }
            else
            {
                Debug.Print("File Does not exist");
            }
            return tempString;
        }

        private static string GetRootPath()
        {
            return Directory.GetCurrentDirectory() + @"\wwwroot\";
        }

    }
    
}
