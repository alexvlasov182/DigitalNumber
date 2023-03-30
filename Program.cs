namespace System;

class DigitalNumbers
{
  static void Main()
  {
    var input = Console.ReadLine();

    // validation
    var intValidator = new IntValidator();
    intValidator.Validate(input);
    Console.WriteLine(input);
    try
    {
      // print output
    }
    catch (System.Exception)
    {

      throw;
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
}