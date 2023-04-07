//Grading ID: R5560
//Lab 6 
//Due Date: March 21, 2021;
//Course Section: CIS 199-01
//Description: Program displays a variety of patterns using for loops and nested for loops.
//Patterns are made of * and spaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10; //The max number of rows each pattern uses. Also used for number of stars and spaces. 

            WriteLine("Pattern A");
            //Displays Pattern A
            for (int row = 1; row <= MAX_ROWS; row++)//row is used to determine what row the pattern is on
            {
                for (int star = 1; star <= row; star++)//star is used to determine how many stars are on said row
                    Write("*");
                WriteLine();
            }

            WriteLine();
            WriteLine("Pattern B");
            WriteLine();

            for(int row = 1; row <= MAX_ROWS; row++)//Displays Pattern B
            { 
                for(int star = 10; star >= row; star--)//variable are same for this one
                    Write("*");
                WriteLine();
            }

            WriteLine();
            WriteLine("Pattern C");
            WriteLine();

            for (int row = MAX_ROWS; row >= 1; row--)//Displays Pattern C
            {
                for (int space = 1; space <= MAX_ROWS - row; space++)//space is used to determine how many spaces are per row. 
                    Write(" ");//Other than that, same as the rest. 
                for (int star = 1; star <= row; star++)
                    Write("*");
                WriteLine();
            }

            WriteLine();
            WriteLine("Pattern D");
            WriteLine();

            for (int row = MAX_ROWS; row >= 1; row--)//Displays Pattern D
            {
                for (int space = 8; space >= MAX_ROWS - row; space--)//same as the rest
                    Write(" ");
                for (int star = 10; star >= row; star--)
                    Write("*");
                WriteLine();
            }
        }
    }
}
