using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        void Breakfast()
        {
            var bird = new Animal<Egg>(); //what type of offspring does this animal have?
            var pig = new Animal<Piglet>();
        }

        public class Animal<T> where T : Offspring //using this to "group" things
        {
            public T Offspring { get; set; }

        }

        public class Rocket<T> where T : Nation
        {
            public T Nation { get; set; }
        }

        public abstract class Nation { }
        public class Soviet : Offspring { }
        public class Allied : Offspring { }


        public abstract class Offspring {}
        public class Egg : Offspring {}
        public class Piglet : Offspring {}
    }
}
