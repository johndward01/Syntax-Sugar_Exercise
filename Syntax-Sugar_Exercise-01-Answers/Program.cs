using System;

namespace Syntax_Sugar_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Complete all of the TODOs then push back to GitHub


            // TODO: Refactor this IF/ELSE Statement into an inline-if using the ternary operator with syntax sugar best practices in mind
            int x = 0;
            int y = 1;

            //if (x > y)
            //{
            //    string answer = "X is greater than Y.";
            //}
            //else
            //{
            //    string answer = "Y is greater than X.";
            //}

            // TODO: Refactor here
            var answer = x > y ? "X is greater than Y." : "Y is greater than X.";

            // TODO: Print out the answer to the console
            Console.WriteLine(answer);



            // TODO: Refactor this IF/ELSE Statement into an inline-if using the ternary operator with syntax sugar best practices in mind
            var evens = new int[] { 2, 4, 6, 8, 10 };
            int first = evens[0];            

            //if (first % 2 == 0)
            //{
            //    string answer1 = "It is even.";
            //}
            //else
            //{
            //    string answer1 = "It is odd.";
            //}

            // TODO: Refactor here
            var answer1 = first % 2 == 0 ? "It is even." : "It is odd.";

            // TODO: Print out the answer to the console
            Console.WriteLine(answer1);



            // TODO: Refactor this IF/ELSE Statement into an inline-if using the ternary operator with syntax sugar best practices in mind
            var odds = new int[] { 1, 3, 5, 7, 9 };
            int first1 = odds[0];

            //if (first % 2 != 0)
            //{
            //    string answer2 = "It is even.";
            //}
            //else
            //{
            //    string answer2 = "It is odd.";
            //}

            // TODO: Refactor here
            var answer2 = first1 % 2 != 0 ? "It is even." : "It is odd.";

            // TODO: Print out the answer to the console
            Console.WriteLine(answer2);


            // TODO: Refactor this IF/ELSE Statement into an inline-if using the ternary operator with syntax sugar best practices in mind
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();

            //if (firstName.ToLower() == "john" && lastName.ToLower() == "doe" && password == "password123")
            //{
            //    string greeting = $"Welcome, Admin: {firstName} {lastName}.";
            //}
            //else
            //{
            //    string greeting = $"Welcome, {firstName} {lastName}.";
            //}

            // TODO: Refactor here
            var greeting = firstName.ToLower() == "john" && lastName.ToLower() == "doe" && password == "password123" ? $"Welcome, Admin: {firstName} {lastName}." : $"Welcome, {firstName} {lastName}.";

            // TODO: Print out the greeting to the console
            Console.WriteLine(greeting);
        }
    }
}
