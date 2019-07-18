using System;

namespace Lab6_PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            string message = "Enter an integer: ";
            Console.WriteLine("Learn your cubes and squares!");
            do
            {
                int num;
                string input = ReceiveInteger(message);
                if(int.TryParse(input, out num))
                {
                    DisplayResult(num);
                    again = AskContinue();
                }
                else
                {
                    Console.WriteLine("That was not the correct input, please try again");
                }




            } while (again);
            Console.WriteLine();
            Console.WriteLine("Keep up the learning!\nHave a great day.");
        }

        public static int CubeIt(int num)
        {
            double doubleNum = (double)num;
            double cubed = Math.Pow(doubleNum, 3);
            int result = (int)cubed;
            return result;
        }

        public static int SquareIt(int num)
        {
            double doubleNum = (double)num;
            double squared = Math.Pow(doubleNum, 2);
            int result = (int)squared;
            return result;
        }

        public static string ReceiveInteger(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void DisplayResult(int input)
        {
            
            Console.WriteLine("Number     Squared    Cubed");
            Console.WriteLine("======     =======    =====");
            
            for (int i = 1; i <= input; i++)
            {
                int squared = SquareIt(i);
                int cubed = CubeIt(i);
                string header = string.Format("{0,-10} {1,-10} {2,-10}", i, squared, cubed);
                //Console.WriteLine("{0} {1} {2}", i, squared, cubed);
                Console.WriteLine($"{header}");
            }
        }
        public static bool AskContinue()
        {
            bool trueFalse;
            string Input = "";
            while (Input != "y" && Input != "n")
            {
                Console.Write("Would you like to calculate again? y/n: ");
                Input = Console.ReadLine().ToLower();
            }
            
            if(Input == "y")
            {
                trueFalse = true;
            }
            else
            {
                trueFalse = false;
            }
            return trueFalse;


        }
    }
}
