using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesAndStructs
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Syntax of a struct
        /// A struct is a value type
        /// 
        /// Immutable; values don't change
        /// 
        /// Logically represents a single value
        /// Can have a performance benefits
        /// </summary>
        public struct Point
        {
            public int X { get; set; }

            public int Y { get; set; }
        }
        /// <summary>
        /// Syntax of a class
        /// 
        /// Is a reference type
        /// 
        /// "Static" => cannot be instantiated
        /// "Abstract" => cannot be instantiated; incomplete class; must be completed by a derived class
        /// "Sealed" =>
        /// </summary>
        public class Animal
        {

        }

    }
}
