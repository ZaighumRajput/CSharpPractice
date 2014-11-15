using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace LinqExample
{
    class Program
    {
        /// <summary>
        /// LINQ examples from MVA
        /// Illustrates the two syntax of LINQ
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var data = Enumerable.Range(1, 100);

            //Definition; not execution
            //it is a queray-able (sp?) project
            var method =
                data.Where(x => x % 2 == 0) //predicate (something that returns true or false)
                .Select(x => x.ToString()); //projection, take the data and project into a new type

            var query =
                from d in data
                where d % 2 == 0
                select d.ToString();


            Debugger.Break();
            
            //Expression tree..?

            var project =
                from d in data
                select new
                {
                    Even = (d % 2 == 0),
                    Odd = !(d % 2 == 0),
                    Value = d,
                };

            var letters = new[] { "A", "C", "B", "E", "Q" };

            var SortAcc =
                from al in letters
                orderby al ascending
                select al;

            var sortDesc =
                letters.OrderByDescending(x => x);

            // aggregates

            var numbers = Enumerable.Range(1, 50);
            var any = numbers.Any(x => x % 2 == 0); 
            var count = numbers.Count(x => x % 2 == 0);

        }
    }
}
