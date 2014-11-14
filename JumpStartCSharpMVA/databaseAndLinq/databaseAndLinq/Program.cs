using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseAndLinq
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
