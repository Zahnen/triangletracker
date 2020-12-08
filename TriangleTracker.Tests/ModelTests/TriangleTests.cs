using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.TestTools
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_IsOneSideLongerThanOthersCombined_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(2,1,1));
    }
    
  }
}