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
      var matricies = input?.Select(c => matrixCollection.GetMatrix(c));
      var heightOfMatrix = matricies?.First().Length;

      for (var lineNumber = 0; lineNumber < heightOfMatrix; ++lineNumber)
      {
        var lines = matricies?.Select(m => m[lineNumber]);
        if (lines != null)
        {
          foreach (var line in lines)
          {
            foreach (string element in line)
            {
              Console.Write(element);
            }
          }
          Console.WriteLine();
        }
      }
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
        '2' => new string[][]
       {
          new [] {" ", "_", " "},
          new [] {" ", "_", "|"},
          new [] {"|", "", "_"}},
        '3' => new string[][]
        {
          new [] {" ", "_", " "},
          new [] {" ", "_", "|"},
          new [] {" ", " _", "|"}
        },
        '4' => new string[][]
        {
          new [] {" ", " ", " "},
          new [] {"|", "_", "|"},
          new [] {" ", " ", "|"},
        },
        '5' => new string[][]
        {
          new [] {" ", " ", "_"},
          new [] {" |", "_", " "},
          new [] {" ", " _", "|"}
        },
        '6' => new string[][]
        {
          new [] {" ", " ", " _"},
          new [] {" |", "_", " "},
          new [] {" |", "_", "|"}
        },
        '7' => new string[][]
        {
          new [] {" ", " _", " "},
          new [] {" ", " ", "|"},
          new [] {" ", " ", "|"}
        },
        '8' => new string[][]
        {
          new [] {" ", " _", " "},
          new [] {" |", "_", "|"},
          new [] {" |", "_", "|"}
        },
        '9' => new string[][]
        {
          new [] {" ", " _", " "},
          new [] {" |", "_", "|"},
          new [] {" ", " _", "|"}
        },
        _ => throw new ArgumentOutOfRangeException(nameof(c), c, "no exists matrix for this integer")
      };
    }
  }
}