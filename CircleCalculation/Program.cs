using System;

namespace CircleCalculation
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new Circle();
            instance._Radius = 5;
            Console.WriteLine("Arean för en cirkel med radien 5 är " + instance.GetArea() + " cm^2");
            instance._Radius = 6;
            Console.WriteLine("Arean för en cirkel med radien 6 är " + instance.GetArea() + " cm^2");
        }
    }
    //Console.WriteLine("Arean för en cirkel med radien 5 är " + instance.GetArea(5) + "cm^2");
    //Console.WriteLine("Arean för en cirkel med radien 6 är " + instance.GetArea(6) + "cm^2"); 
}
