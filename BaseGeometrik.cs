using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorfihism
{
    public class BaseGeometric
    {
        //defined the main class property
        public double Height { get; set; }
        public double Weight { get; set; }

        // defined the main virtul method for the overriding
        public virtual double AreaCalculate(double _height, double _weight)
        {
            return _height * _weight;// main calculate the area 
        }


        public class Triangle : BaseGeometric
        {
            public override double AreaCalculate(double _height, double _weight)
            {

                return (_height * _weight) / 2;// if it it geometric shape is triangle we ovveride the main virtual method
            }
        }


        public class Square : BaseGeometric
        {

            public override double AreaCalculate(double _height, double _weight)
            {

                if (_height == _weight)
                {
                    return _height * _height; //if it is square the paramteres must to be eqqual we added if statment control 

                }
                else 
                {
                    return 0; // else return 0
                }

           }

        }
            public class Rctaangle : BaseGeometric
            {

                public override double AreaCalculate(double _height, double _weight)
                {
                    return base.AreaCalculate(_height, _weight);//it is recatangle and it isn't has any spesfiaction so we use the base callculate
                }

            
        }
    }
}






    
