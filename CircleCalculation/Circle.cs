using System;

public class Circle
{
    
    public float _Pi = 3.141f;
    public int Radius;

    public Circle(int Radius)
    {
       this.Radius = Radius;
    }
    public float GetArea()
    {
        float _Area = (Radius * Radius) * _Pi;
        return _Area;
    }

}
    
 



