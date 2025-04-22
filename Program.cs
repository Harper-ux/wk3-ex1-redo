using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3_ex1_redo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the numeric score (0-100)? ");

            double score = Convert.ToDouble(Console.ReadLine());

                score = Math.Round(score); //round the score to the nearest whole number
                switch (score / 10)
                {
                    case 10: // if the score is 100
                        break;
                    case 9: // if the score is 90-99
                        score = 'A';
                        break;
                    case 8: // if the score is 80-89
                        score = 'B';
                        break;
                    case 7: // if the score is 70-79
                        score = 'C';
                        break;
                    case 6: // if the score is 60-69
                        score = 'D';
                        break;
                    case 5: // if the score is 50-59
                        score = 'F';
                        break;
                }

                Console.WriteLine("The letter grade is: " + score); //display the letter grade to the user
            }

        }
    }

