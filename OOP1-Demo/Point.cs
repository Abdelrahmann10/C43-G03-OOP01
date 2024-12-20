using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_Demo
{
    internal struct Point
    {
        // Attributes
        public int x;
        public int y;
        //------------------------
        // Constructor : Is a special Function
         //1- Named always with the same name of the Class Or Struct
         //2- Has ni return

        // By default at struct, compiler will always generate peremeterless constructor
        public Point()
        {
            x = 0; 
            y = 0;
        }
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        } // Method
        public override string ToString()
        {
            return $"The x = {x} , y = {y}";
        }
    }
}
