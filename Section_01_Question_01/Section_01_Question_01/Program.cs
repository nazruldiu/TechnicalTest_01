using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Section_01_Question_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Get("<p> Hello <b> Bangladesh </b> </p>");
        }

        static void Get(string file)
        {
            var input = file;
            var token = "<>";

            var allTags = input.Split().Where(str => token.All(c => str.Contains(c))).ToArray();

            for (int i= 0; i < allTags.Length; i++)
            {
                Console.WriteLine(allTags[i]);
                var currentTag = allTags[i];
                int j = 0;
                while(j < currentTag.Length)
                {
                    if(j+1 < currentTag.Length && currentTag[j] == '<' && currentTag[j+1] == '/')
                    {

                    }
                }
            }
        }
    }
}
