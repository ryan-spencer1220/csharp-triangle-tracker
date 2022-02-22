using System;
using TriangleTracker;

namespace TriangleInterface {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter three triangle side lengths.");
      int sideOneLength = int.Parse(Console.ReadLine());
      int sideTwoLength = int.Parse(Console.ReadLine());
      int sideThreeLength = int.Parse(Console.ReadLine());

      Triangle shape = new Triangle(sideOneLength, sideTwoLength, sideThreeLength);

      Console.WriteLine(shape.TriangleTracker());
    }
  }
}