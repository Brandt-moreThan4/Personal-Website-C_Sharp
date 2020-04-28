using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FunWithBrandt.Models.Data
{
    public static class ConnectionStrings
    {

        public static string WebData = "Data Source = " + Directory.GetCurrentDirectory() + @"\wwwroot\" + @"Data\WebData.db; Version = 3";
    }
}
