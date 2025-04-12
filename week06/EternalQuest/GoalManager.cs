using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void CreateGoal(string type, string name, string description, int points, int target = 0, int bonus = 0)
    {
        Goal goal = null;
        switch (type.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(name, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, description, points);
                break;
            case "checklist":
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
        }
        if (goal != null)
        {
            _goals.Add(goal);
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _score += _goals[goalIndex].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string[] details = parts[1].Split(',');
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            CreateGoal("simple", details[0], details[1], int.Parse(details[2]));
                            break;
                        case "EternalGoal":
                            CreateGoal("eternal", details[0], details[1], int.Parse(details[2]));
                            break;
                        case "ChecklistGoal":
                            CreateGoal("checklist", details[0], details[1], int.Parse(details[2]), 
                                int.Parse(details[4]), int.Parse(details[3]));
                            break;
                    }
                }
            }
        }
    }

    public int GetGoalCount()
    {
        return _goals.Count;
    }
} 