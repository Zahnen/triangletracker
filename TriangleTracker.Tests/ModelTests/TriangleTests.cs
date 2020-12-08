using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.TestTools
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_IsATriangle_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsTriangle(2,1,1));
    }

    [TestMethod]
    public void IsTriangle_IsAnEquilateralTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsEquilateral(2,2,3));
    }
  }
}