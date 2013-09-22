using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top;
using it=Top.InsideTop;
namespace the_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Top.Inside x = new Top.Inside();
            x.FirstName = "yona";

            Inside y = new Inside();
            y.FirstName = "yossi";

            Top.InsideTop.Inside z = new Top.InsideTop.Inside();
            z.LastName = "ben david";

            it.Inside a = new it.Inside();
            a.LastName = "levi";
           
            //System.Data.SqlClient.SqlConnection 
            //System.Data.OleDb.OleDbConnection
        }
    }
}

namespace Top
{
    class Inside
    {
        public string FirstName { get; set; }
    }
    namespace InsideTop
    {
        class Inside
        {
            public string LastName { get; set; }
        }
    }
}
