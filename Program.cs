namespace System;

class DigitalNumbers
{
  static void Main()
  {
    var input = Console.ReadLine();

    // validation
    var intValidator = new IntValidator();
    intValidator.Validate(input);

    // matrix collection
    var matrixCollection = new MatrixCollection();

    try
    {
      // print output
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
      return;
    }
  }

  // create class for validation
  public class IntValidator
  {
    public void Validate(string? input)
    {
      var isValid = int.TryParse(input, out var _);
      if (!isValid)
      {
        throw new ArgumentException("Invalid input");
      }
    }
  }
  // create data for our task
  public class MatrixCollection
  {
    public string[][] GetMatrix(char c)
    {
      return c switch
      {
        '0' => new string[][]
        {
          new [] {" ", "_", " "},
          new [] {"|", " ", "|"},
          new [] {"|", "_", "|"},
        },
        '1' => new string[][]
        {
          new [] {" ", " ", " "},
          new [] {" ", " ", "|"},
          new [] {" ", " ", "|"},
        },
        _ => throw new ArgumentOutOfRangeException(nameof(c), c, "no exists matrix for this integer")
      };
    }
  }
}