namespace System;
using global::DigitalNumbers.MatrixCollection;
using global::DigitalNumbers.IntValidator;
using global::DigitalNumbers.MatrixPrint;

class DigitalNumbers
{
  static void Main()
  {
    try
    {
      var input = Console.ReadLine();
      // validation our int
      var intValidator = new IntValidator();
      intValidator.Validate(input);

      // working with our task data and print it
      var matrixCollection = new MatrixCollection();
      var matrixPrint = new MatrixPrint();
      var matricies = input?.Select(c => matrixCollection.GetMatrix(c));

      if (matricies != null)
      {
        matrixPrint.Print(matricies);
      }

    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
      return;
    }
  }
}