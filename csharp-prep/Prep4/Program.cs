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

        int sum = 0;
        foreach (int num in numList)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        float averageNum = ((float)sum) / numList.Count;
        Console.WriteLine($"The average is: {averageNum}");

        int maxNum = numList[0];

        foreach (int numb in numList)
        {
            if (numb > maxNum)
            {
                maxNum = numb;
            }
        }
        Console.WriteLine($"The maximum number  is: {maxNum}");
    }
}