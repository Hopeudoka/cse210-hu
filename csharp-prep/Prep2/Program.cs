using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int numGrade = int.Parse(grade);

        string letter = null;
        string sign = null;

        if (numGrade >= 90)
        {
            letter = "A";
        }
        else if (numGrade >= 80)
        {
            letter = "B";
        }
        else if (numGrade >= 70)
        {
            letter = "C";
        }
        else if (numGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        int dividedNum = numGrade % 10;

        if (dividedNum >= 7)
        {
            if (letter == "A" || letter == "F")
            {
                sign = "";
            }
            else
            {
                sign = "+";   
            }
        }
        else if (dividedNum < 3)
        {
            if (letter == "F" || numGrade == 100)
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }
        else
        {
            sign = "";
        }


        Console.WriteLine($"Your Grade is {letter}{sign}.");





        if (numGrade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class.");
        }
        else 
        {
            Console.WriteLine("You did not pass the class. Study hard and try again next time");
        } 
    }
}