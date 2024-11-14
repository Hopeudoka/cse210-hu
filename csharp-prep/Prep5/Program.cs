using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("What is your Username? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string userNum = Console.ReadLine();
        int userFavNum = int.Parse(userNum);
        return userFavNum;
    }

    static int SquareNumber(int num)
    {
        int squaredNum = num * num;
        return squaredNum;
    }

    static void DisplayResult(string userName, int squaredNum)
    {
        Console.WriteLine($"{userName}, the square of your num is {squaredNum}");
    }

}