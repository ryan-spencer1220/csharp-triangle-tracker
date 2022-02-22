using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]

  public class TriangleTrackerTests
  {
    [TestMethod]
    public void TriangleTracker_AcceptThreeNumbers_String()
    {
      Triangle testTriangle = new Triangle(2, 2, 2);
      Assert.AreEqual("equilateral", testTriangle.TriangleTracker());
    }
    [TestMethod]
    public void TriangleTracker_ReturnEquilateralTriangle_String()
    {
      Triangle testTriangle = new Triangle(2, 2, 2);
      Assert.AreEqual("equilateral", testTriangle.TriangleTracker());
    }
    [TestMethod]
    public void TriangleTracker_ReturnIsoscelesTriangle_String()
    {
      Triangle testTriangle = new Triangle(2, 2, 7);
      Assert.AreEqual("isosceles", testTriangle.TriangleTracker());
    }
    [TestMethod]
    public void TriangleTracker_CheckValidTriangle_String()
    {
      Triangle testTriangle = new Triangle(1, 2, 10);
      Assert.AreEqual("not a triangle", testTriangle.TriangleTracker());
    }
    [TestMethod]
    public void TriangleTracker_ReturnScaleneTriangle_String()
    {
      Triangle testTriangle = new Triangle(3, 4, 5);
      Assert.AreEqual("scalene", testTriangle.TriangleTracker());
    }
  }
}