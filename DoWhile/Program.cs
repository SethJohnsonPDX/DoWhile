using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year is it?");
            int yearGuess = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            do
            {
                switch (yearGuess)
                {
                    case 2000:
                        Console.WriteLine("Ahhh Y2K! Just kidding, you're wrong. Try again.");
                        Console.WriteLine("What year is it?");
                        yearGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3001:
                        Console.WriteLine("From the future huh? Why did you bother coming back?");
                        Console.WriteLine("What year is it?");
                        yearGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2018:
                        Console.WriteLine("Boom! Nailed it.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect. Try again.");
                        Console.WriteLine("What year is it?");
                        yearGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.Read();
        }
    }
}
