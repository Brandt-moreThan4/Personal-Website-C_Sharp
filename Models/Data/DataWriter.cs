using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace FunWithBrandt.Models.Data
{
    public class DataWriter
    {
        public static KnowledgeRecord KnowledgeAdd(KnowledgeRecord newKnowledgeRecord)
        {
            using (IDbConnection connection = new SQLiteConnection(ConnectionStrings.WebData))
            {
                connection.Execute("INSERT INTO Knowledge (Person_Institution,Description,Source,Keywords) VALUES" +
                    " (@Person_Instituion, @Description,@Source,@Keywords)", newKnowledgeRecord);


                //connection.Execute("INSERT INTO Knowledge (Person_Institution,Description,Source,Keywords) VALUES" +
                //    " ('Brandtyy','Test','www.haha.com','program;lolol')");
            }

            return newKnowledgeRecord;
        }

        public static void KnowledgeDelete(KnowledgeRecord newKnowledgeRecord)
        {

            using (IDbConnection connection = new SQLiteConnection(ConnectionStrings.WebData))
            {
               
                
                //connection.Execute("DELETE FROM Knowledge WHERE Person_Institution = 'Brandt'");
            }
        }
    }
}
