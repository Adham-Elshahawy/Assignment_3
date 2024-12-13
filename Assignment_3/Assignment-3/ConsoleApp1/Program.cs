using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            /*Q1*/
            //Console.WriteLine("Enter the number"); 

            //int Number = int.Parse(Console.ReadLine());

            //if (Number % 3 == 0 && Number % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}   
            //else 
            //{ 
            //    Console.WriteLine("no"); 
            //}
            /*************************************************/
            /*Q2*/

            //Console.WriteLine("Enter  Number ");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number > 0)
            //{
            //    Console.WriteLine("postive");
            //}
            //else if (Number < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("its zero");
            //}

            /*****************************************************/

            ///*q3*/

            // Console.WriteLine("enter your numbers");

            //int number0 = int.Parse(Console.ReadLine());
            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());

            //int maxValue = Math.Max(Math.Max(number0, number1), number2);

            //// Find the minimum value by comparing pairs
            //int minValue = Math.Min(Math.Min(number0, number1), number2);

            //Console.WriteLine($"max = {maxValue}");
            //Console.WriteLine($"min = {minValue}");
            /********************************************************/

            //console.writeline(" enter your number ");
            //int number = int.parse(console.readline());
            //    if  (number %2 == 0)
            //{
            //    console.writeline(" your number is even ");
            //}
            //else
            //{
            //    console.writeline(" your number is odd ");
            //}

            /************************************************************/
            /*Q5*/

            //Console.WriteLine("Enter your letter ");

            //char letter = char.Parse(Console.ReadLine());

            //if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
            //    letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            //{
            //    Console.WriteLine(" this letter is vowel ");
            //}
            //else
            //{
            //    Console.WriteLine("this letter is consonant");
            //}

            /****************************************************************/

            /*Q7*/

            //Console.WriteLine(" Enter your Number ");

            //int Number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    int result = Number * i;
            //    Console.WriteLine("          ");
            //    Console.WriteLine($"{result}");
            //}

            /*****************************************************************************/

            /*Q9*/

            //Console.WriteLine(" Enter your Numbers ");

            //int Number = int.Parse(Console.ReadLine());
            //int Number1 = int.Parse(Console.ReadLine());

            //int Result = (int)Math.Pow(Number, Number1);

            //Console.WriteLine($" {Number} ^ {Number1} = {Result} ");

            /********************************************************************************/

            /*10*/

            //Console.WriteLine("Enter Mark's grades ");

            //int number = int.Parse(Console.ReadLine());
            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());
            //int number3 = int.Parse(Console.ReadLine());
            //int number4 = int.Parse(Console.ReadLine());

            //int Totol_mark_s = number + number1 + number2 + number3 + number4;
            //int Average = (number + number1 + number2 + number3 + number4) / 5;
            //double Precentage = ((number + number1 + number2 + number3 + number4) / 500.0) * 100;

            //Console.WriteLine($"total mark's = {Totol_mark_s}");
            //Console.WriteLine($"Average = {Average}");
            //Console.WriteLine($"Percentage  = {Precentage}%");

            /************************************************************************************/

            /*Q11*/

            //static int GetDaysInMonth(int year, int month)
            //{

            //    if (month < 1 || month > 12)
            //    {
            //        Console.WriteLine("Invalid month number. Please enter a value between 1 and 12.");
            //        return -1; 
            //    }


            //    return DateTime.DaysInMonth(year, month);
            //}

            //Console.WriteLine("Enter month number ");

            //int month_number = int.Parse(Console.ReadLine());
            //int year = DateTime.Now.Year;
            //int daysInMonth = GetDaysInMonth(year, month_number);

            //Console.WriteLine($"Number of days in month {month_number} = {daysInMonth}");

            /*************************************************************************************************/

            /*Q17*/

            // Ask user to input the coordinates of three points
            //    Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            //    Console.Write("x1: ");
            //    int x1 = int.Parse(Console.ReadLine());
            //    Console.Write("y1: ");
            //    int y1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            //    Console.Write("x2: ");
            //    int x2 = int.Parse(Console.ReadLine());
            //    Console.Write("y2: ");
            //    int y2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            //    Console.Write("x3: ");
            //    int x3 = int.Parse(Console.ReadLine());
            //    Console.Write("y3: ");
            //    int y3 = int.Parse(Console.ReadLine());

            //    // Check if the points are collinear
            //    if (ArePointsCollinear(x1, y1, x2, y2, x3, y3))
            //    {
            //        Console.WriteLine("The points are collinear (lie on a straight line).");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The points are not collinear (do not lie on a straight line).");
            //    }
            //}

            //// Function to check if three points are collinear
            //static bool ArePointsCollinear(int x1, int y1, int x2, int y2, int x3, int y3)
            //{
            //    // Using the collinearity condition: (x2 - x1) * (y3 - y1) == (x3 - x1) * (y2 - y1)
            //    return (x2 - x1) * (y3 - y1) == (x3 - x1) * (y2 - y1);

            //}

            /************************************************************************************************/

            /*Q18*/

            //Console.WriteLine("Enter Number of hours So we can requrieed the quality of worker");

            //int Number = int.Parse(Console.ReadLine()); 

            //if (Number >= 2 && Number <= 3)
            //{
            //    Console.WriteLine(" they are considered highly efficient. ");
            //}
            //else if (Number > 3 && Number <= 4)
            //{
            //    Console.WriteLine(" they are instructed to increase their speed. ");
            //}
            //else if (Number > 4 && Number <= 5)
            //{
            //    Console.WriteLine(" they are provided with training to enhance their speed. ");
            //}
            //else if (Number > 5)
            //{
            //    Console.WriteLine("Terminated: The worker took more than 5 hours to complete the task.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid time input. Time taken cannot 1 or 0 ");
            //}

            ///*21*/

            //int number1 = 10;
            //int number2 = number1;

            //number1 = 20;

            //Console.WriteLine($"number1: {number1}");  /*will be 20*/
            //Console.WriteLine($"number2: {number2}");   /*will be 10 */

            /***************************************************************************************/

            /*Q22*/

            //Person person1 = new Person();
            //person1.Name = "John";


            //Person person2 = person1;


            //person1.Name = "Jane";


            //Console.WriteLine($"person1's Name: {person1.Name}");   /*will be john*/
            //Console.WriteLine($"person2's Name: {person2.Name}");  /*will be john*/

            /***************************************************************************/

            /*Q23*/

            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            ///*b) value1  will be assigned  */

            /*Q24*/

            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            /*It suppose to be 6.5 and 1 but console says 6 and 1 so idk which one is more correct */


            /*25*/

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z); /*that step will be affect and give the answer  */
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            //answer: d) 7 , 7 


        }
    }
}
