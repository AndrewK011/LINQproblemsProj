using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> classGrades = new List<string>()
            {
             "80,100,92,89,65",
             "93,81,78,84,69",
             "73,88,83,99,64",
             "98,100,66,74,55"
            };

            Strings s = new Strings();

            words = s.GetWordsWithTH(words);
            s.PrintNewList(words);

            var result = s.ReturnListMinusDuplicateStrings(names);
            s.PrintNewList(result);

            Console.WriteLine(s.ReturnAverageOfStringList(classGrades));
            Console.ReadLine();

        }
    }
}
