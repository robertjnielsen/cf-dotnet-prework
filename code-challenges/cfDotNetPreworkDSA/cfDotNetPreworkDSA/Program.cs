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
            Console.WriteLine($"\nWelcome {userName}, let's play a game.\n");
            return userName;
        }

        static int[] ArrayMaxChoices()
        {
            int[] maxResultArray = new int[5];

            Console.WriteLine("The first thing I'm going to ask you to do is to give me five numbers, each between 1 and 10.");

            for (int i = 0; i < maxResultArray.Length; i++)
            {
                Console.Write($"\nNumber {i + 1}) Please give me a number between 1 and 10:  ");
                int num;
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num >= 1 && num <= 10)
                    {
                        maxResultArray[i] = num;
                    }
                    else
                    {
                        Console.WriteLine("\nYour number must be between 1 and 10.");
                        i--;
                    }

                }
                else
                {
                    Console.WriteLine("\nPlease enter a number between 1 and 10.");
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
            Console.WriteLine("\nAwesome! Now I'm going to ask you for one more number.");
            Console.Write("Please choose one of the numbers from your list:  ");
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
