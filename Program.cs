using PolyMorfihism;
using System;
using System.Drawing;
using static PolyMorfihism.BaseGeometric;
namespace Polly
    
    {


    class Polly
    {
        public static void Main(string[] args) {


            BaseGeometric sqr = new Square(); // we produce instance for the square class

            Console.WriteLine($"Square is Area:{sqr.AreaCalculate(10, 10)} M^2"); 
            
            
            BaseGeometric rct = new Rctaangle();// we produce instance for the rectangle class

            Console.WriteLine($"Rectangle is Area:{rct.AreaCalculate(10, 12)} M^2");

            BaseGeometric trg = new Triangle();// we produce instance for the triangle class

            Console.WriteLine($"Triangle is Area:{trg.AreaCalculate(10, 12)} M^2");




        }

    }

}
