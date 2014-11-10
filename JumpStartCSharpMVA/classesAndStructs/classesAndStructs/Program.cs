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
        public abstract class Animal
        {
            // can be accessed from derived class but not publically
            protected void Bar() { }
        }

        /// <summary>
        /// A derived class
        /// </summary>
        public class Dog : Animal
        {
            public string Name { get; set; } //short hand for:

            private string _name;
            public string Name
            {
                get { return _name; }
                set
                {
                    //some other stuff
                    _name = value;
                }
            }

            // only by this class
            private void Foo() { }

            //only in this assembly or solution
            internal void Bar() { }

            //executes within the object
            void x() { this.Bar(); }


        }
    }
}
