using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {


        
        

                    
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess = -1;
        

        do
        {
           
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            

            if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }

        } while (magic != guess);


        
    }
}