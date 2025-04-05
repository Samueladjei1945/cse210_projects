using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        Start();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
        End();
    }
} 