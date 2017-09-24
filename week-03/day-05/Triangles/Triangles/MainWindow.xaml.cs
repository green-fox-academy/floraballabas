using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace Triangles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double x = 0;
            double y = 0;
            double w = canvas.Width;
            double h = canvas.Height;
            DrawTriangle(x, y, w, h);

        }
        public double DrawTriangle(double x, double y, double w, double h)
        {
            var foxDraw = new FoxDraw(canvas);
            double distance = w - x;
            foxDraw.DrawLine(x, y, w, y);
            foxDraw.DrawLine(w, y, w/2, h);
            foxDraw.DrawLine(w/2, h, x, y);
            //foxDraw.DrawLine(x, y, w/2, y);
            //foxDraw.DrawLine(w / 2, y, w / 4, h / 2);
            //foxDraw.DrawLine(w/4, h/2, x, y);
            //foxDraw.DrawLine(w/2, y, w, y);
            //foxDraw.DrawLine(w, y, w / 1.335, h / 2);
            //foxDraw.DrawLine(w / 1.335, h / 2, w/2, y);
            //foxDraw.DrawLine(w/4, h/2, w/1.335, h/2);
            //foxDraw.DrawLine(w/1.335, h/2, w / 2, h);
            //foxDraw.DrawLine(w / 2, h, w/4, h/2);
            if (distance > 10)
            {
                DrawTriangle(x, y, w/2, h-h);
                //DrawTriangle(w/2, y, w, y);
                //DrawTriangle(w / 4, h / 2, w / 1.335, h / 2);
            }
            return 0;
            //int distanceX = endX - x;
            //int distanceY = y - y / 2;

            //foxDraw.DrawLine(x, y, endX, endY);
            //foxDraw.DrawLine(endX, endY, endX - distanceX / 2, endY / 2);
            //foxDraw.DrawLine(x, y, endX - distanceX / 2, endY / 2);
            //if (distanceX > 150)
            //    return DrawTriangle(x - (distanceX / 2), (y / 3) * 2, endX - (distanceX / 2 + distanceX / 6), (endY / 3) * 2);
            //return 0;

            ////private int DrawTriangle(int x, int y, int w, int h)
            ////{
            ////    int distanceX = w - x;
            ////    var foxDraw = new FoxDraw(canvas);
            ////    foxDraw.DrawLine(x, h, w, h);
            ////    foxDraw.DrawLine(w, h, h, y);
            ////    foxDraw.DrawLine(x, h, h, y);

            ////    if (distanceX > 150)
            ////        return DrawTriangle(x - (distanceX / 2), y+h/2, w-(3*x), h/2);
            ////    return 0;
            ////}
        }
    }
}
        

