using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows:");
        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {number} = {row * number}");
        }
        WriteLine();
    }

    static decimal CaclulateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = 0.0M;
        switch (twoLetterRegionCode)
        {
            case "CH": // Switzerland
                rate = 0.08M;
                break;
            case "DK": // Denmark
            case "NO": // Norway
                rate = 0.25M;
                break;
            case "GB": // United Kingdom
            case "FR": // France
                rate = 0.2M;
                break;
            case "HU": // Hungary
                rate = 0.27M;
                break;
            case "OR": // Oregon
            case "AK": // Alaska
            case "MT": // Montana
                rate = 0.0M;
                break;
            case "ND": // North Dakota
            case "WI": // Wisconsin
            case "ME": // Maine
            case "VA": // Virginia
                rate = 0.05M;
                break;
            case "CA": // California
                rate = 0.0825M;
                break;
            default: // most US states
                rate = 0.06M;
                break;
        }
        return amount * rate;
    }

    static string CardinalToOrdinal(int number)
    {
        int lastTwoDigits = number % 100;
        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                int lastDigit = number % 10;

                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }

    static void RunCardinalToOrdinal()
    {
        for (int number = 1; number<=150; number++)
        {
            Write($"{CardinalToOrdinal(number)}");
        }
        WriteLine();
    }

    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(message: $"The factorial function is defined for non-negative integers only. Input: {number}", paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number-1);
            }
        };
    }

    static void RunFactorial()
    {
        for (int i = -2; i <= 15; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }
}
