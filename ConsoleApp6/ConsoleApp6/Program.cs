using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput1 = int.Parse(Console.ReadLine());
            int userInput2 = int.Parse(Console.ReadLine());
            Console.WriteLine(userInput1 + userInput2);
            Console.WriteLine(userInput1 - userInput2);
            Console.WriteLine(userInput1 * userInput2);
            Console.WriteLine(userInput1 / userInput2);

            string userName = Console.ReadLine();
            Console.WriteLine("Hello");
            Console.WriteLine(userName);

            int userInput3 = int.Parse(Console.ReadLine());
            int userInput4 = int.Parse(Console.ReadLine());
            int userInput5 = int.Parse(Console.ReadLine());
            Console.WriteLine(userInput3 * userInput4 * userInput5);

            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("You look younger than " + userAge);
        }
    }
}
