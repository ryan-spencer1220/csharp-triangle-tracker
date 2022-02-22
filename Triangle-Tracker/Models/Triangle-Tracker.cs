namespace TriangleTracker
{
  public class Triangle
  {
    public int _sideOne;
    public int _sideTwo;
    public int _sideThree;

    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      _sideOne = sideOne;
      _sideTwo = sideTwo;
      _sideThree = sideThree;
    }
    public string TriangleTracker()
    {
      if (_sideOne == _sideTwo &&  _sideOne == _sideThree && _sideTwo == _sideThree) 
      {
        return "equilateral";
      }
      else if (_sideOne == _sideTwo || _sideTwo == _sideThree || _sideThree == _sideOne)
      {
        return "isosceles";
      }
      else if (_sideOne + _sideTwo <= _sideThree || _sideTwo + _sideThree <= _sideOne || _sideThree + _sideOne <= _sideTwo) {
        return "not a triangle";
      }
      else
      {
        return "scalene";
      }
    }
  }
}