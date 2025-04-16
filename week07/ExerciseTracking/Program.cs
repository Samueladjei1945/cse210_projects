using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8), // 4.8 km in 30 min
            new StationaryBicycle(new DateTime(2022, 11, 3), 45, 20.0), // 20 kph for 45 min
            new Swimming(new DateTime(2022, 11, 3), 40, 30) // 30 laps in 40 min
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}