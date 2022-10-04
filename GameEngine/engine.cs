using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace GameEngine
{
    public class Canvas : Form
    {

        public Canvas()
        {
            this.DoubleBuffered = true;
        }

        private void InitializeComponent()
        {

            // 
            // Canvas
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Canvas";
            this.Load += new System.EventHandler(this.Canvas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Canvas_Load(object sender, EventArgs e)
        {

        }

    }
    public abstract class engine
    {
        public static context.newScreen ScreenSize = new context.newScreen(500, 500);
        public string Title = "";
        public string Icon = "";
        public Canvas Window = null;
        private Thread GameLoopThread = null;
        public static bool A, W, S, D;
        public static List<Rectangle> RenderStack = new List<Rectangle>();
        public static List<Circle> RenderStackCircle = new List<Circle>();

        public engine(context.newScreen ScreenSizee, string title, string Icon)
        {
            ScreenSize = ScreenSizee;
            
            this.Title = title;
            this.Icon = Icon;
            Window = new Canvas();
            Window.Size = new System.Drawing.Size((int)ScreenSize.X, (int)ScreenSize.Y);
            Window.Text = this.Title;
            Window.Icon = new Icon("icon.ico");
            Window.Paint += Renderer;
            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.SetApartmentState(ApartmentState.STA);
            GameLoopThread.Start();


            System.Windows.Forms.Application.Run(Window);

        }

        // FIGURAS GEOMETRICAS
        public static void RegisterTriangle(Rectangle s) // TRIANGULO
        {
            if(s != null)
            {
                RenderStack.Add(s);
            }
        }

        public static void RegisterCircle(Circle c) // CIRCULO
        {
            if (c != null)
            {
                RenderStackCircle.Add(c);
            }
        }

        private void GameLoop()
        {
            OnLoad();
            while(true)
            {
                try
                {
                    
                    Window.BeginInvoke((MethodInvoker)delegate { Window.Refresh(); });
                    OnUpdate();
                    Thread.Sleep(1);
                } catch (Exception) { }
            }
        }

        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            List<Rectangle> Render = new List<Rectangle>(RenderStack);
            List<Circle> RenderCircle = new List<Circle>(RenderStackCircle);
            foreach (Rectangle s in Render)
            {
                
                g.FillRectangle(new SolidBrush(s.color), (int)s.Position.X, (int)s.Position.Y, (int)s.Scale.X, (int)s.Scale.Y);
             
            }

            foreach(Circle c in RenderCircle)
            {
                g.FillEllipse(new SolidBrush(c.color), (int)c.Position.X, (int)c.Position.Y, (int)c.Radius.X, (int)c.Radius.Y);
            }


        }
        public abstract void OnLoad();
        public abstract void OnUpdate();

    }
}
