using System;
using System.Globalization;
using System.Linq;

public class TextCalculator
{
     public string Add(string numbers)
     {
          if (string.IsNullOrWhiteSpace(numbers))
          {
               return "0";
          }

          string[] parts = numbers.Split(',');

          // Check for missing number in the last position
          if (numbers.EndsWith(","))
          {
               throw new InvalidOperationException("Missing number in last position.");
          }

          // Convert to numbers and check for negatives
          var negativeNumbers = parts.Where(n => !string.IsNullOrEmpty(n) && decimal.Parse(n, CultureInfo.InvariantCulture) < 0).ToArray();
          if (negativeNumbers.Any())
          {
               throw new InvalidOperationException($"Negative not allowed: {string.Join(", ", negativeNumbers)}");
          }

          // Convert to decimals
          var validNumbers = parts.Select(n =>
          {
               if (decimal.TryParse(n, NumberStyles.Any, CultureInfo.InvariantCulture, out var num))
               {
                    return num;
               }
               throw new InvalidOperationException($"Invalid number: {n}");
          }).ToArray();

          // Sum the numbers
          decimal sum = validNumbers.Sum();

          // Return sum as string
          return sum.ToString(CultureInfo.InvariantCulture);
     }
}
