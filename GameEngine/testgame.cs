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

        public testgame() : base(new window.newScreen(500, 500), "2d WFGE", "test")
        {
        }
        public override void OnLoad()
        {
            Console.WriteLine(new window.getScreen().Width());
            //p = new Rectangle(new vector(0, 25), new vector(50, 50), Color.Red);
            //p2 = new Rectangle(new vector(0, 200), new vector(50, 50), Color.Aqua);
            circle = new Circle(new vector(0, 125), new vector(50, 50), Color.Red);
            //Console.WriteLine("Console");
        }


        public override void OnUpdate()
        {
           // p.Position.X += 1;
            //p2.Position.X += 1;
            circle.Position.X += 1;
           /*if(p.Position.X > 500)
            {
                p.Position.X -= 5;
            }
            if (p2.Position.X > 500)
            {
                p2.Position.X -= 5;
            }*/

        }
    }
}
