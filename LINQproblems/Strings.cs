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

        public void PrintNewList(IEnumerable<string> stringToPrint)
        {
            foreach (string word in stringToPrint)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }

        public IEnumerable<string> ReturnListMinusDuplicateStrings(List<string> listParam)
        {
            IEnumerable<string> enumerable = listParam.Distinct();

            return enumerable;
        }

        public double ReturnAverageOfStringList(List<string> listParam)
        {
            List<string> newList;
            List<double> studentAverageList = new List<double>();
            List<double> overallAverageList = new List<double>();
            string[] splitString;

            foreach (string gradeSet in listParam)
            {
                splitString = gradeSet.Split(',');
                newList = splitString.ToList();

                studentAverageList = ConvertStringListToDoubleList(newList);
                RemoveLowestValueInList(studentAverageList);
                overallAverageList.Add(studentAverageList.Average());
            }


            return overallAverageList.Average();
        }

        public void RemoveLowestValueInList(List<double> listParam)
        {
            listParam.Remove(listParam.Min());
        }

        public List<double> ConvertStringListToDoubleList(List<string> listParam)
        {
            List<double> convertedList = new List<double>();

            foreach (string stringToConvert in listParam)
            {
                if (double.TryParse(stringToConvert, out double convertedString))
                {
                    convertedList.Add(convertedString);

                }
            }
            return convertedList;
        }

    }
}
