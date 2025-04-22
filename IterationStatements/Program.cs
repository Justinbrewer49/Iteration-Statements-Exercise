using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintEveryThirdNmber()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static void AreNubersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal");

            }
            else
            { 
                Console.WriteLine("The numbers are not equal");
            
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
               Console.WriteLine("The number is negative");
            
            }
        }

        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static void CanVote()
        {
            Console.WriteLine("Enter your age:");
            var input = Console.ReadLine();
            var success = int.TryParse(input, out int age);

            while (!success)
        {
                Console.WriteLine("Please enter a valid age:");
                success = int.TryParse(Console.ReadLine(), out age);
            }

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
        }
            else
        {
                Console.WriteLine("You are not eligible to vote");
            }
    }

       
        
        // Fixed the `IsInRange` method to return a boolean value instead of using an invalid statement.
        public static bool IsInRange(int number)
{
    if (number >= -10 && number <= 10)
            {
                Console.WriteLine("is in range"); return false;
            }
    else
            {
                Console.WriteLine("is not in range"); return true;
            }
}
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
       public static void DisplayMultiplecationTable(int Number)
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
            //  PrintNumbers();
            // PrintEveryThirdNmber();
            // AreNubersEqual(5, 3);
            //IsEven(5);
            //ispositive(-109);
            //CanVote();
            //IsInRange(12);
            //DisplayMultiplecationTable(12);
        }
    }   
}

