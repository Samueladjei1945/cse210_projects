using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():0.##} km, Speed: {GetSpeed():0.##} kph, Pace: {GetPace():0.##} min per km";
    }
}

public class Running : Activity
{
    private double _distanceKm;

    public Running(DateTime date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance() => _distanceKm;
    public override double GetSpeed() => (_distanceKm / Minutes) * 60.0;
    public override double GetPace() => Minutes / _distanceKm;
}

public class StationaryBicycle : Activity
{
    private double _speedKph;

    public StationaryBicycle(DateTime date, int minutes, double speedKph)
        : base(date, minutes)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance() => _speedKph * Minutes / 60.0;
    public override double GetSpeed() => _speedKph;
    public override double GetPace() => 60.0 / _speedKph;
}

public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50.0;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * LapLengthMeters / 1000.0;
    public override double GetSpeed() => GetDistance() / Minutes * 60.0;
    public override double GetPace() => Minutes / GetDistance();

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Swimming ({Minutes} min): Distance {GetDistance():0.##} km, Speed: {GetSpeed():0.##} kph, Pace: {GetPace():0.##} min per km";
    }
}
