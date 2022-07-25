using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int NumberToGuess = random.Next(0, 101);
            Console.WriteLine("GuessTheNumber the number !");
            string nr;
            int MyNumber;
            do
            {   
                nr = Console.ReadLine();
                while(!int.TryParse(nr, out MyNumber))
                {
                    Console.WriteLine("Invalid Input, try again: ");
                    nr = Console.ReadLine();
                }

                if(MyNumber>NumberToGuess)
                {
                    Console.WriteLine("Number too big");
                    Console.WriteLine("Try again");
                }else
                    if(MyNumber<NumberToGuess)
                {
                    Console.WriteLine("Number too small");
                    Console.WriteLine(" Try again ");
                }

            } while (MyNumber != NumberToGuess);

            Console.WriteLine("Your number is correct");
            Console.WriteLine("Well done ! :)");


        }
    }
}
