using System;

namespace cfDotNetPreworkDSA
{
    class Program
    {
        static void Main()
        {
            string userName = GreetUser();
            MainMenu(userName);
        }

        static string GreetUser()
        {
            Console.WriteLine("Welcome! What's your name?");
            string userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\nWelcome {userName}, let's play a game.\n");
            return userName;
        }

        static void MainMenu(string userName)
        {
            Console.Clear();
            Console.WriteLine($"{userName}, Please Enter A Number To Choose An Application...\n");
            Console.Write("1: Array Max Result \n2: Leap Year Calculator \n3: Quit Application \n");
            Console.Write("\nPlease enter a menu option:  ");

            int menuChoice;
            if (int.TryParse(Console.ReadLine(), out menuChoice))
            {
                switch (menuChoice)
                {
                    case 1:
                        ArrayMaxSuper(userName);
                        break;
                    case 2:
                        LeapYearCalculator(userName);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a menu number.\n");
                        MainMenu(userName);
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a menu number.\n");
                MainMenu(userName);
            }
        }

        static void ArrayMaxSuper(string userName)
        {
            int[] maxResultArray = ArrayMaxChoices();
            int maxSelector = ArrayMaxSelector(maxResultArray);
            ArrayMaxResult(maxResultArray, maxSelector, userName);
        }

        static int[] ArrayMaxChoices()
        {
            int[] maxResultArray = new int[5];

            Console.Clear();
            Console.WriteLine("\nThe first thing I'm going to ask you to do is to give me five numbers, each between 1 and 10.");

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
            Console.WriteLine("\nAwesome! Now I'm going to ask you for one more number.\n");
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
            Console.WriteLine("Press (ENTER / RETURN) to continue...");
            Console.ReadLine();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Would you like to run this application again?\n");
                Console.WriteLine("1: Run Again \n2: Main Menu \n3: Quit Application\n");
                Console.Write("Enter a menu number:  ");
                int playAgain;
                if (int.TryParse(Console.ReadLine(), out playAgain))
                {
                    switch (playAgain)
                    {
                        case 1:
                            ArrayMaxSuper(userName);
                            break;
                        case 2:
                            MainMenu(userName);
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Let's try this again...");
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Let's try this again...");
                    Console.ReadLine();
                }
            }
        }

        static void LeapYearCalculator(string userName)
        {
            Console.Clear();
            Console.Write($"{userName}, please enter a four digit year:  ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 == 0)
                {
                    Console.WriteLine($"\n{year} is a Leap Year.");
                    Console.Write("\nPress any key to continue. ");
                    Console.ReadLine();
                }
                else if (year % 100 == 0 && year % 400 != 0)
                {
                    Console.WriteLine($"\n{year} is not a Leap Year.");
                    Console.Write("\nPress any key to continue. ");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine($"\n{year} is a Leap Year.");
                    Console.Write("\nPress any key to continue. ");
                    Console.ReadLine();

                }
            }
            else
            {
                Console.WriteLine($"\n{year} is not a Leap Year.");
                Console.Write("\nPress (ENTER / RETURN) to continue. ");
                Console.ReadLine();

            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Would you like to run this application again?\n");
                Console.WriteLine("1: Run Again \n2: Main Menu \n3: Quit Application\n");
                Console.Write("Enter a menu number:  ");
                int playAgain;
                if (int.TryParse(Console.ReadLine(), out playAgain))
                {
                    switch (playAgain)
                    {
                        case 1:
                            LeapYearCalculator(userName);
                            break;
                        case 2:
                            MainMenu(userName);
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Let's try this again...");
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Let's try this again...");
                    Console.ReadLine();
                }
            }
        }

        static void PerfectSequence(int[] arr)
        {
            int sum = 0;
            int prod = 1;
            foreach (int i in arr)
            {
                sum += i;
                prod *= i;
            }
            if (sum == prod)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
