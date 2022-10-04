using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngine
{
    class testgame : engine
    {
        private Rectangle p;
        private Rectangle p2;
        private Circle circle;

        public testgame() : base(new context.newScreen(500, 500), "2d WFGE", "test")
        {
        }
        public override void OnLoad()
        {
            Console.WriteLine(new context.getScreen().Width());
            p = new Rectangle(new vector(0, 25), new vector(50, 50), Color.Red);
            p2 = new Rectangle(new vector(0, 200), new vector(50, 50), Color.Aqua);
            //circle = new Circle(new vector(0, 125), new vector(50, 50), Color.Red);
            //Console.WriteLine("Console");
            
        }


        public override void OnUpdate()
        {
            //new getCollision(p.Position.X, p2.Position.X, p.Position.Y, p2.Position.Y, p.Scale.Y, p2.Scale.Y, p.Scale.X, p.Scale.X);
           
            if (new physic().getCollision(p.Position.X, p2.Position.X, p.Position.Y, p2.Position.Y, p.Scale.Y, p2.Scale.Y, p.Scale.X, p.Scale.X))
            {
                //p.Position.Y = 25;
                p.Position.Y -= 2;
            }
            if(new context.keyboard().readKey("W")) 
            {
                p.Position.Y += 1;
            }
          
            //circle.Position.X += 1;
            if (p.Position.X > 500)
            {
                p.Position.X -= 5;
            }
            if (p2.Position.X > 500)
            {
                p2.Position.X -= 5;
            }

        }
    }
}
