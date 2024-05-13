using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rastgeleSayiTahmini
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            while (true)
            {
                int randomNumber = random.Next(1, 11);
                try
                {
                    Console.WriteLine("Please make a guess. (1 to 10)");
                    string guess = Console.ReadLine();
                    int userGuess = int.Parse(guess);

                    if (userGuess >0 && userGuess <=10)
                    {
                        Console.WriteLine("Number: {0}", randomNumber);
                        if (randomNumber == userGuess)
                        {
                            Console.WriteLine("Congratulations, your guess is correct!");
                            Console.ReadLine();
                            break;
                        }
                        else if (randomNumber < userGuess)
                        {
                            Console.WriteLine("Bad luck! Your guess is bigger than random number.");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Bad luck! Your guess is smaller than random number.");
                            Console.ReadLine();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The number your entered is not between 1 and 10");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            }
        }
    }
}