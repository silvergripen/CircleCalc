using System;

namespace CircleCalculation
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Circle c2 = new Circle(6);
            Console.WriteLine("Arean på cirkelnn när radien är {0} {1} cm^2", 5, c1.GetArea());
            Console.WriteLine("Arean på cirkelnn när radien är {0} {1} cm^2", 6, c2.GetArea());
        }
  
    }
   
}
