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
            Get("<p>Hello <b> Bangladesh </b></p>");
        }

        static void Get(string file)
        {
            var input = file;

            var pattern = @"(?<=\<)(.*?)(?=\>)";
            var regex = new Regex(pattern);
            var allTags = regex.Matches(file).ToArray();

            for (int i = 0; i < allTags.Length; i++)
            {
                var currentTag = allTags[i].ToString();
                if (currentTag[0] == '/')
                {
                    Console.WriteLine("Expected # found {0}", "<" + currentTag + ">");
                    return;
                }
                var currentClsTag = "/"+ currentTag;
                bool isFound = false;

                for (int j = i + 1; j < allTags.Length; j++)
                {
                    if (currentClsTag.ToString() == allTags[j].ToString())
                    {
                        isFound = true;
                        int firstFoundIndex = Array.IndexOf(allTags, allTags[j]);
                        allTags = allTags.Where((source, index) => index != firstFoundIndex).ToArray();

                        break;
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("Expected {0} found #", "<" + currentClsTag.ToString() + ">");
                    return;
                }
            }

            Console.WriteLine("Correctly tagged paragraph");
        }
    }
}
