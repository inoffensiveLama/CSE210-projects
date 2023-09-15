using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        
        do{
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > magicNumber){
                Console.WriteLine("lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }
        } while(guess != magicNumber);
        
        Console.WriteLine($"you guessed correct. the magic number was {magicNumber}");

    }
}