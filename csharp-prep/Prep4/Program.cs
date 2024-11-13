using System;

class Program
{
    static void Main(string[] args)
    {
        int newNumber = 1;

        List<int> numList = new List<int>();

        while (newNumber != 0)
        {
            Console.Write("Enter a number. When you are ready to end, type 0. ");
            string number = Console.ReadLine();
            newNumber = int.Parse(number);

            if (newNumber == 0)
            {
                break;
            }
            else
            {
                numList.Add(newNumber);
            }   
        }

        foreach (int num in numList)
        {
            Console.WriteLine(num);
        }
    }
}