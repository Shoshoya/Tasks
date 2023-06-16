using System;
using System.Collections.Generic;

public class Organizer
{
    private static List<string> tasks = new List<string>();

    public static void Main(string[] args)
    {
        Console.WriteLine("Organizer");
        Console.WriteLine("MineOrganizer");

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void AddTask()
    {
        Console.Write("Enter the task: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Task added successfully.");
    }

    private static void ViewTasks()
    {
        Console.WriteLine("\nTasks:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}


