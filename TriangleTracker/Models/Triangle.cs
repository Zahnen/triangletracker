namespace TriangleTracker
{
  public class Triangle
  {
    public bool IsTriangle(int side1, int side2, int side3)
    {
      if ((side1 + side2 < side3) || (side2 + side3 < side1) || (side1 + side3 < side2))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool IsEquilateral(int side1, int side2, int side3)
    {
      if (side1 == side2 && side2 == side3 && side1 == side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool IsIsosceles(int side1, int side2, int side3)
    {
      if((side1 == side2 && side1 != side3) || (side2 == side3 && side2 != side1) || (side1 == side3 && side3 != side2))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool IsScalene(int side1, int side2, int side3)
    {
      if(side1 != side2 && side2 != side3 && side1 != side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}