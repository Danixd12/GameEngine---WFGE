using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{

    public class physic
    {
        //double x1, double x2, double y1, double y2, double w1, double w2, double h1, double h2
        public Boolean getCollision(double x1, double x2, double y1, double y2, double w1, double w2, double h1, double h2)
        {
            return (x1 < x2 + w2
               && x2 < x1 + w1
               && y1 < y2 + h2
               && y2 < y1 + h1);

        }
    }

}
