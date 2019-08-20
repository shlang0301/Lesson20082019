using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20082019
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input line! (format: City name = Population value, Area Value;");//user enter string in programm
            string s = Console.ReadLine(); 
            
            string[] t = s.Split(';'); //create array from input string, elements are separated with symbol ; 
                       
            int sizeArray = t.Length; //define length of array
                    
            string[] citiesNames = new string[t.Length]; //create array with cities names

            for (int i = 0; i < t.Length; i++)
            {
                citiesNames[i]=t[i].Substring(0, t[i].IndexOf('='));//take a substring before the symbol =
            }

            int [] citiesPopulation = new int[t.Length];

            for (int i = 0; i < t.Length; i++)
            {
                citiesPopulation[i] = int.Parse(t[i].Split('=', ',')[1]);
            }

            //foreach (int item in citiesPopulation)
            //{
            //    Console.WriteLine(item);
            //}

            int[] citiesArea = new int[t.Length];

            for (int i = 0; i < t.Length; i++)
            {
                citiesArea[i] = int.Parse(t[i].Split(',')[1]);
            }

            //foreach (int item in citiesArea)
            //{
            //    Console.WriteLine(item);
            //}

            int maxElemMostPopulation = citiesPopulation.Max();
            int indexElemMostPopulation = citiesPopulation.ToList().IndexOf(maxElemMostPopulation);

           // Console.WriteLine(indexElemMostPopulation);

            Console.WriteLine("Most populated: {0} ({1} people)", citiesNames[indexElemMostPopulation], maxElemMostPopulation);


            int [] citiesNamesLength = new int[t.Length];

            for (int i = 0; i < t.Length; i++)
            {
                citiesNamesLength[i] = t[i].Length;
            }

            //foreach (int item in citiesNamesLength)
            //{
            //    Console.WriteLine(item);
            //}

            int maxElemCitiesNamesLength = citiesNamesLength.Max();
            int indexElemCitiesNamesLength = citiesNamesLength.ToList().IndexOf(maxElemCitiesNamesLength);

            // Console.WriteLine(indexElemCitiesNamesLength);

            Console.WriteLine("Longest name: {0}({1} letters)", citiesNames[indexElemCitiesNamesLength], citiesNamesLength[indexElemCitiesNamesLength]);

            Console.WriteLine("Density:");

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine("{0} - {1}", citiesNames[i], Math.Round((Convert.ToDouble(citiesPopulation[i]) / Convert.ToDouble(citiesArea[i])),2) );
            }

            Console.ReadLine();

        }
    }
}
