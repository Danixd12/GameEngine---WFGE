using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class window
    {

  
        public class newScreen
        {
            public double X { get; set; }
            public double Y { get; set; }

            /// <summary>
            /// Create a new window, with the values given.
            /// 
            /// <list type="number" >X, Y</list>
            ///</summary>
            public newScreen(double X, double Y)
            {
                this.X = X;
                this.Y = Y;
            }

       
        }

        public class getScreen
        {
            public double Width ()
            {
                return engine.ScreenSize.X;
            }

            public double Height()
            {
                return engine.ScreenSize.Y;
            }
        
        
        }

       
    }  


}
