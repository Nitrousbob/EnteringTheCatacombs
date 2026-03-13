using System;
using System.Collections.Generic;
using System.Text;

namespace EnteringTheCatacombs
{
    internal class Point
    {
        public int x;
        public int y;
        
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point() 
        { 
            x=0; y=0;  // Default constructor initializes to (0, 0)
        }

        // Override ToString for easy debugging and display
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
