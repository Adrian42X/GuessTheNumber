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
            int NumberToGuess = random.Next(1, 100);
            Console.WriteLine("GuessTheNumber the number !");
            string nr;
            int MyNumber;
            do
            {   
                nr = Console.ReadLine();
                MyNumber = int.Parse(nr);

                if(MyNumber>NumberToGuess)
                {
                    Console.WriteLine("Number too big\n Try again \n");
                }else
                    if(MyNumber<NumberToGuess)
                {
                    Console.WriteLine("Number too small\n Try again \n");
                }

            } while (MyNumber != NumberToGuess);

            Console.WriteLine("Your number is correct \n Well done ! :)");
           
        }
    }
}
