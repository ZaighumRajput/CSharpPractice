﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualAndOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseClass = new BaseClass();
            var derivedOverride = new DerivedOverride();
            var derivedNew = new DerivedNew();
            var derivedOverwrite = new DerivedOverwrite();

            baseClass.Name()            ;
            derivedOverride.Name()      ;
            derivedNew.Name()           ;
            derivedOverwrite.Name();

            Console.WriteLine("Now we cast back to base class and see the effects");
            ((BaseClass)baseClass).Name();
            ((BaseClass)derivedOverride).Name();
            ((BaseClass)derivedNew).Name();
            ((BaseClass)derivedOverwrite).Name();
            

            Console.ReadLine();
            baseClass.Name();

        }
    }

    internal class BaseClass
    {
        /// <summary>
        /// A virtual method doesn't need to be overidden, but the intention is that it might be
        /// </summary>
        internal virtual void Name()
        {
            Console.WriteLine("BaseClass");
        }
    }

    internal class DerivedOverride : BaseClass
    {
        internal override void Name()
        {
            Console.WriteLine("DerivedOverride");
        }
    }

    internal class DerivedNew : BaseClass
    {
        internal new void Name()
        {
            Console.WriteLine("New");
        }
    }

    internal class DerivedOverwrite : BaseClass
    {
        internal void Name() //hiding the base implementation
        {
            Console.WriteLine("Overwrite");
        }
    }


}
