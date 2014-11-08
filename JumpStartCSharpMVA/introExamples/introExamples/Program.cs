using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Everything is inherited from type "Object"
            var adam = new Object();

            Console.Write(adam.ToString());
            Console.Write(adam.GetType());
            Console.Write(adam.GetHashCode());

            Console.Read();
            
        }
    }
}
