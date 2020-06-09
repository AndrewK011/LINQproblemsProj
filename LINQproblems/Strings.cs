using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblems
{
    class Strings
    {
        public List<string> GetWordsWithTH(List<string> listParam)
        {
            List<string> newList = new List<string>();

            foreach(var word in listParam)
            {
                if(word.Contains("th"))
                {
                    newList.Add(word);
                }
            }
            return newList;
        }

        public void PrintNewList(List<string> stringToPrint)
        {
            foreach (string word in stringToPrint)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
