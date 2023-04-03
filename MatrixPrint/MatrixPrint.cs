namespace DigitalNumbers.MatrixPrint
{
  public class MatrixPrint
  {
    public void Print(IEnumerable<string[][]> matricies)
    {
      var height = matricies.First().Length;
      for (int lineNumber = 0; lineNumber < height; ++lineNumber)
      {
        var lines = matricies
            .Select(m => m[lineNumber])
            .Select(line => string.Join("", line));
        var combinedMatrixLine = string.Join("", lines);
        Console.WriteLine(combinedMatrixLine);
      }
    }
  }
}
