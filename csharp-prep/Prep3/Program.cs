using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int updateMagicNum = randomGenerator.Next(1, 101);

        int updateGuessNum = -1;

        while (updateMagicNum != updateGuessNum)
        {
            Console.Write("Guess the magic number ");
            string guessNumber = Console.ReadLine();
            updateGuessNum = int.Parse(guessNumber);

            if (updateGuessNum < updateMagicNum) 
            {
                Console.WriteLine("Higher");
            }
            else if (updateGuessNum > updateMagicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        }
    }
}