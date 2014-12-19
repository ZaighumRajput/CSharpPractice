using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO.IsolatedStorage;

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
            //infoAndMoving();
            // foldersExample();
            //example1();
            


        }

        private static void infoAndMoving()
        {
            var desk = Environment.SpecialFolder.Desktop;
            var temp = new System.IO.DirectoryInfo(Environment.GetFolderPath(desk));

            foreach (var item in System.IO.Directory.GetFiles(Environment.GetFolderPath(desk)))
            {
                Console.WriteLine(System.IO.Path.GetFileName(item));
                var info = new System.IO.FileInfo(item);
                Console.WriteLine("{0}kb", info.Length);

            }
        }

        private static void foldersExample()
        {
            //Special folders
            var docs = Environment.SpecialFolder.MyDocuments;
            var app = Environment.SpecialFolder.CommonApplicationData;
            var prog = Environment.SpecialFolder.ProgramFiles;
            var desk = Environment.SpecialFolder.Desktop;


            foreach (var a in Enumerable.Range(0, 12))
            {
                var filenameee = "File" + a + ".txt";
                System.IO.File.WriteAllText(System.IO.Path.Combine(Environment.GetFolderPath(desk), filenameee), a.ToString());

            }

            var iso = IsolatedStorageFile
                .GetStore(IsolatedStorageScope.Assembly, "Demo")
                .GetDirectoryNames("*");

            
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
