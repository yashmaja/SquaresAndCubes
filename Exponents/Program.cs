using System;

namespace Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            getInputandExecute();

        }

        public static void getInputandExecute()
        {
            bool repeat = true;
            
            while (repeat)
            {
                Console.Write("Please enter an integer from 1-1290: ");
                string value = Console.ReadLine();
             
                //check if user input is a number
                bool success = int.TryParse(value, out int input);

                if (success)
                {
                    if (input > 0 && input <= 1290)
                    {
                        squaresAndCubes(input);

                        while (true)
                        {
                            Console.Write("Would you like to continue? (y/n): ");
                            string answer = Console.ReadLine();

                            if (answer == "n")
                            {
                                Console.WriteLine("\nGoodbye!");
                                repeat = false;
                                break;
                            }
                            else if (answer == "y")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid input. Try again.\n");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Try again.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Try again.\n");
                }
            }
        }

        public static void squaresAndCubes(int num)
        {
            num = Math.Abs(num);
            int[,] numList = new int[3, num];

            const int numColSpace = 13;
            Console.WriteLine("\nNumber\t\tSquared\t\tCubed");
            Console.WriteLine("=======\t\t=======\t\t======");

            for (int i = 1; i <= num; i++)
            {
                int indexNum = i - 1;
                numList[0, indexNum] = i;
                numList[1, indexNum] = i * i;
                numList[2, indexNum] = i * i * i;
                Console.WriteLine($"{$"{numList[0, indexNum]}", numColSpace}{$"{numList[1, indexNum]}",numColSpace}{$"{numList[2, indexNum]}",numColSpace}");

            }
        }
    }
}
