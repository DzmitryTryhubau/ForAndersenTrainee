using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzmitryTryhubauAnderserTrainee
{
    //Dzmitry Tryhubau, Homel, AQA, C#.
    class Program
    {
        static void Main(string[] args)
        //Uncomment what you need
        {

            //Task one
            /*Console.WriteLine("Please, write number.");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input > 7)
            {
                Console.WriteLine("Hi number is greater than seven");
            }
            else 
            {
                Console.WriteLine("Hi number is less than seven");
            }
            Console.ReadLine();*/

            // Task two
            /*Console.WriteLine("Please, write name.");
            var input = Console.ReadLine();
            if (input is string)
            {
                string name = "вячеслав";
                if (name == input.ToLower())
                {
                    Console.WriteLine("Привет " + input);
                }
                else
                {
                    Console.WriteLine("Нет Такого имени");
                }
             Console.ReadLine();
            }*/

            //Task three

            /*Console.Write("Please, write number of colums\n");
            int columns = int.Parse(Console.ReadLine());
            Console.Write("Please, write number of rows\n");
            int rows = int.Parse(Console.ReadLine());
            int[,] array = new int[columns, rows];
            Console.WriteLine("Please fill array");
            for(int i = 0; i < array.GetLength(0); i++)
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("columns: " + i + " rows: " + j);
                    array[i, j] = int.Parse(Console.ReadLine());
                    
                }

            Console.WriteLine("You array is:");
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                { 
                    
                    Console.Write(array[i, j] + "\t");
                }

            Console.WriteLine("\nNumbers that are multiples of three:");
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 3 == 0)
                    {
                        Console.Write(array[i,j] + "\t");
                    }
                }
            Console.ReadLine();*/

            //Task four
            //  [((())()(())]] is wrong
            //  [((()))()(())] is correct
        }

    }
       
}
