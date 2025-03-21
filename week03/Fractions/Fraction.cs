public class Fraction
{
    // Private attributes for numerator (top) and denominator (bottom)
    private int numerator;
    private int denominator;

    // Default constructor that initializes the fraction as 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor that takes one parameter for the numerator, and sets denominator to 1
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    // Constructor that takes both numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator != 0 ? denominator : 1; // Prevent division by zero
    }

    // Getter and setter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int value)
    {
        numerator = value;
    }

    // Getter and setter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    public void SetDenominator(int value)
    {
        if (value != 0) // Denominator should never be zero
        {
            denominator = value;
        }
    }

    // Method to get the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
