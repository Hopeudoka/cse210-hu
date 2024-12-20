using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter Goal Type (1: Simple, 2: Eternal, 3: Checklist): ");
                    int goalType;
                    if (!int.TryParse(Console.ReadLine(), out goalType) || goalType < 1 || goalType > 3)
                    {
                        Console.WriteLine("Invalid goal type. Please try again.");
                        break;
                    }

                    Console.Write("Enter Goal Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter Points: ");
                    int points;
                    if (!int.TryParse(Console.ReadLine(), out points) || points <= 0)
                    {
                        Console.WriteLine("Invalid points. Please enter a positive number.");
                        break;
                    }

                    if (goalType == 1)
                    {
                        goalManager.AddGoal(new SimpleGoal(name, description, points));
                    }
                    else if (goalType == 2)
                    {
                        goalManager.AddGoal(new EternalGoal(name, description, points));
                    }
                    else if (goalType == 3)
                    {
                        Console.Write("Enter Target Count: ");
                        int target;
                        if (!int.TryParse(Console.ReadLine(), out target) || target <= 0)
                        {
                            Console.WriteLine("Invalid target count. Please enter a positive number.");
                            break;
                        }
                        Console.Write("Enter Bonus Points: ");
                        int bonus;
                        if (!int.TryParse(Console.ReadLine(), out bonus) || bonus < 0)
                        {
                            Console.WriteLine("Invalid bonus points. Please enter a non-negative number.");
                            break;
                        }
                        goalManager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                    }
                    break;

                case "2":
                    goalManager.DisplayGoals();
                    Console.Write("Enter the number of the goal to record an event: ");
                    int index;
                    if (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > goalManager.GoalsCount)
                    {
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                    }
                    goalManager.RecordEvent();
                    break;

                case "3":
                    goalManager.DisplayGoals();
                    break;

                case "4":
                    goalManager.DisplayScore();
                    break;

                case "5":
                    // Console.Write("Enter filename to save goals: ");
                    // string saveFile = Console.ReadLine();
                    goalManager.SaveGoals();
                    break;

                case "6":
                    // Console.Write("Enter filename to load goals: ");
                    // string loadFile = Console.ReadLine();
                    goalManager.LoadGoals();
                    break;

                case "7":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}