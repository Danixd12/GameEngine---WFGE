using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Rectangle
    {
        public vector Position { get; set; }
        public vector Scale { get; set; }
        public Color color = Color.Black;

        public Rectangle(vector position, vector scale, Color color)
        {
            Position = position;
            Scale = scale;
            this.color = color;
            engine.RegisterTriangle(this);
        }

       
    }
    public class Circle
    {
        public vector Position { get; set; }
        public vector Radius { get; set; }
        public Color color = Color.Black;

        public Circle(vector position, vector radius, Color color)
        {
            Position = position;
            Radius = radius;
            this.color = color;
            engine.RegisterCircle(this);
        }
    }
}
