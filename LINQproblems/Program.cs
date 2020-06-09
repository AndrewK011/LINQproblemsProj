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
            Strings s = new Strings();

            words = s.GetWordsWithTH(words);
            s.PrintNewList(words);

            var result = s.ReturnListMinusDuplicateStrings(names);
            s.PrintNewList(result);

        }
    }
}
