namespace DigitalNumbers.MatrixCollection
{
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
