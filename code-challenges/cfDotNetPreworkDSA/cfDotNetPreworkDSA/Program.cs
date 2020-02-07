using System;

namespace cfDotNetPreworkDSA
{
    class Program
    {
        static void Main()
        {
            string userName = GreetUser();

            int[] maxResultArray = ArrayMaxChoices();

            int maxSelector = ArrayMaxSelector(maxResultArray);

            ArrayMaxResult(maxResultArray, maxSelector, userName);
        }

        static string GreetUser()
        {
            Console.WriteLine("Welcome! What's your name?");

            string userName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Welcome {userName}, let's play a game.");
            Console.WriteLine();

            return userName;
        }

        static int[] ArrayMaxChoices()
        {
            int[] maxResultArray = new int[5];

            Console.WriteLine("The first thing I'm going to ask you to do is to give me five numbers, each between 1 and 10.");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Number {i + 1}: Please give me a number between 1 and 10.");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num >= 1 && num <= 10)
                {
                    maxResultArray[i] = num;
                }
                else
                {
                    Console.WriteLine("Your number must be between 1 and 10.");
                    i--;
                }
            }

            return maxResultArray;
        }

        static int ArrayMaxSelector(int[] maxResultArray)
        {
            string maxArray = "Your chosen numbers are: ";

            for (int i = 0; i < maxResultArray.Length; i++)
            {
                if (i == maxResultArray.Length - 1)
                {
                    maxArray += Convert.ToString(maxResultArray[i]);
                }
                else
                {
                    maxArray += Convert.ToString(maxResultArray[i]);
                    maxArray += ", ";
                }
            }

            Console.WriteLine();
            Console.WriteLine(maxArray);
            Console.WriteLine();
            Console.WriteLine("Awesome! Now I'm going to ask you for one more number. Pleas choose one of the numbers from your list.");
            int maxSelector = Convert.ToInt32(Console.ReadLine());
            return maxSelector;
        }



        static void ArrayMaxResult(int[] maxResultArray, int maxSelector, string userName)
        {
            int selectorFrequency = 0;

            for (int i = 0; i < maxResultArray.Length; i++)
            {
                if (maxResultArray[i] == maxSelector)
                {
                    selectorFrequency++;
                }
            }

            int score = maxSelector * selectorFrequency;

            Console.WriteLine();
            Console.WriteLine($"{userName}, your score is: {score}");
        }
    }
}
