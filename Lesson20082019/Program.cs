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

            int [] citiesPopulation = new int[t.Length]; //create array with cities populations

            for (int i = 0; i < t.Length; i++)
            {
                citiesPopulation[i] = int.Parse(t[i].Split('=', ',')[1]); //take a substring between the symbols = and , convert it to int
            }            

            int[] citiesArea = new int[t.Length]; //create area with cities area

            for (int i = 0; i < t.Length; i++)
            {
                citiesArea[i] = int.Parse(t[i].Split(',')[1]);//take a substring after , convert it to int
            }                       

            int maxElemMostPopulation = citiesPopulation.Max(); //find the element with the most value of population
            int indexElemMostPopulation = citiesPopulation.ToList().IndexOf(maxElemMostPopulation);//find the index of element with the most value of population


            Console.WriteLine("Most populated: {0} ({1} people)", citiesNames[indexElemMostPopulation], maxElemMostPopulation);//make first string to output


            int [] citiesNamesLength = new int[t.Length]; //create array with lenghts of cities names

            for (int i = 0; i < t.Length; i++)
            {
                citiesNamesLength[i] = t[i].Length;
            }
            

            int maxElemCitiesNamesLength = citiesNamesLength.Max();//find the element with the most value of lenght cities name
            int indexElemCitiesNamesLength = citiesNamesLength.ToList().IndexOf(maxElemCitiesNamesLength);//find the index of element with the most value of lenght cities name


            Console.WriteLine("Longest name: {0}({1} letters)", citiesNames[indexElemCitiesNamesLength], citiesNamesLength[indexElemCitiesNamesLength]);//make second string to output

            Console.WriteLine("Density:"); //make third string to output

            for (int i = 0; i < t.Length; i++) //make fourth string to output
            {
                Console.WriteLine("{0} - {1}", citiesNames[i], Math.Round((Convert.ToDouble(citiesPopulation[i]) / Convert.ToDouble(citiesArea[i])),2) );//in this line make value of Density and convert it to double
            }

            Console.ReadLine();//wait input user

        }
    }
}
