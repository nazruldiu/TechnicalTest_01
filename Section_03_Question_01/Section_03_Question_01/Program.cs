using System;
using System.IO;

namespace Section_03_Question_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchInDirectory("C:\\Mail");
        }

        static void SearchInDirectory(string directory)
        {
            try
            {
                Console.WriteLine(directory);

                foreach (string f in Directory.GetFiles(directory))
                {
                    Console.WriteLine(f);
                }

                foreach (string d in Directory.GetDirectories(directory))
                {
                    SearchInDirectory(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
