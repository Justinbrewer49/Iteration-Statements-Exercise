﻿using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        static void PrintEveryThirdNmber()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        bool AreNUbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            { 
                return false; 
            
            }
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static void IsEven(int number)
        {
            if (number % 2 == 0)
            { 
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }

        
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static void ispositive(int number)
        {
            if (number > 0)
            {
               Console.WriteLine("The number is positive");
            
            }
            else
            { 
                return false;
            
            }
        }

        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static void CanVote()
        {
            Console.WriteLine($:"Enter your age:");
            var canparse = int.TryParse(Console.ReadLine(), out int userage);

            while (canparse == false)
        {
                Console.WriteLine("please enter valid age");
                canparse = int.TryParse($:Console.ReadLine(), out userage);
            }


            if (userage >= 18)
            {
                Console.WriteLine("You are eligible to vote");
        }
            else
        {
                Console.WriteLine("You are not eligible to vote");
            }
    }

       
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
bool IsInRange(int number)
{
    if (number >= -10 && number <= 10)
            {
                return true;
            }
    else
            {
                return false;
            }
}
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        void DisplayMultiplecationTable(int Number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {Number} = {i * Number}");
            }
        }


        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            
            
        }
    }   
}

