using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Diagnostics;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;
using Microsoft.Extensions.Configuration;


namespace FunWithBrandt.Models.Data
{
    public class DataReader
    {

        public static List<KnowledgeRecord> GetKnowledgeRecords()
        {
            using (IDbConnection connection = new SQLiteConnection(ConnectionStrings.WebData))
            {
                List<KnowledgeRecord> output = connection.Query<KnowledgeRecord>("Select * From Knowledge", new DynamicParameters()).ToList();
                return output;
            }
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
                        book.Author = splitString[2];
                        book.CoverImageName = splitString[3];
                        book.CoverDescription = splitString[4];
                        book.Content = splitString[5];
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
