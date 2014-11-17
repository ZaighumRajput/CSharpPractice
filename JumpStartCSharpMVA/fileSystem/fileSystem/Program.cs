using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace fileSystem
{
    class Program
    {
        /// <summary>
        /// Illustrates interacting with the filesystem
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Special folders
            var docs = Environment.SpecialFolder.MyDocuments;
            var app = Environment.SpecialFolder.CommonApplicationData;
            var prog = Environment.SpecialFolder.ProgramFiles;
            var desk = Environment.SpecialFolder.Desktop;


            foreach(var a in Enumerable.Range(0,12))
            {
                var filenameee = "File" + a + ".txt";
                System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.GetFolderPath(desk), filenameee), a.ToString() );

            }


            //example1();


        }

        private static void example1()
        {
            var dir = System.IO.Directory.GetCurrentDirectory();
            var file = System.IO.Path.Combine(dir, "File.txt");
            var content = "How now brown cow?";
            System.IO.File.WriteAllText(file, content); //simplest way
            var read = System.IO.File.ReadAllText(file);
        }
    }
}
