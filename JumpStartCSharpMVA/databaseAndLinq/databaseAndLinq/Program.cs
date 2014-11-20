using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace databaseAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
           var prog = new Program();
            prog.example2();
        }

        public void example1()
        {
            var context = new Database1Entities();

            var products = context.Products;

            foreach (var item in products
                .Where(x => x.Name.Contains("L")))
                Console.WriteLine(item.Name);


            var prod = products.First(x => x.Name.StartsWith("L"));
            Console.WriteLine(prod.Name);


            prod.Name = "FauxLion Fur hut";
            context.SaveChanges();

            Console.WriteLine(prod.Name);
        }

            /// <summary>
            /// Illustrates delayed execution of LINQ queries
            /// </summary>
            public void example2()
            {

                List<Member> members = new List<Member> {
                new Member() {FirstName = "Standa", LastName="Panda"},
                new Member() {FirstName = "Anton", LastName ="Kuut"}
                };

                var result = from m in members
                                   where m.LastName.Length > 4
                                   select m.FirstName; //ToList();

                foreach (var member in result) Console.WriteLine(member);

                members.Add(new Member() { FirstName = "Brian", LastName = "Rothstein" });

                foreach (var member in result) Console.WriteLine(member);

                Debugger.Break();

                var linqQuery = members.Where(x => x.FirstName.Length > 5);


                Debugger.Break();
            }

        }
            public class Member
        {
            public string FirstName { get; set; }
            public  string LastName { get; set; }
        }
    }
