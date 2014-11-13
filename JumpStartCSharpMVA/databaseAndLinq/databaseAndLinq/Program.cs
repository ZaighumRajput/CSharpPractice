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

            foreach (var product in products)
                Console.WriteLine(product.Name);


            Console.Read();

        }
    }
}
