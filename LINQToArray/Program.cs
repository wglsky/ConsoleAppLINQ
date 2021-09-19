using System;
using System.Linq;

namespace LINQToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ to Array!");
            // Data source
            string[] names = { "Tom", "Jerry", "Bill", "Trump", "Joe", "Obama" };
            // LINQ Query
            var myLinQueryResults = from x in names
                             where x.Contains('m')
                             select x;

            // Show results
            string str = "";
            foreach (var name in myLinQueryResults)
            {
                str += (name + " "); 
            }
            Console.WriteLine(str);
        }
    }
}
