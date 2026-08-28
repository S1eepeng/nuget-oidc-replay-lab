namespace S1eepeng.NuGetOidcReplayLab;

/// <summary>
/// Provides deterministic arithmetic operations for the Trusted Publishing lab package.
/// </summary>
public static class Calculator
{
    /// <summary>Adds two numbers.</summary>
    public static decimal Add(decimal left, decimal right) => left + right;

    /// <summary>Subtracts the second number from the first.</summary>
    public static decimal Subtract(decimal left, decimal right) => left - right;

    /// <summary>Multiplies two numbers.</summary>
    public static decimal Multiply(decimal left, decimal right) => left * right;

    /// <summary>Divides the first number by the second.</summary>
    /// <exception cref="DivideByZeroException">Thrown when <paramref name="right"/> is zero.</exception>
    public static decimal Divide(decimal left, decimal right)
    {
        if (right == 0)
        {
            throw new DivideByZeroException("The divisor cannot be zero.");
        }

        return left / right;
    }
}

