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
            int x = 50;
            int y = 0;
            int w = 250;
            int h = 150;
            DrawTriangle(x, y, w, h);

        }
        public int DrawTriangle(int x, int y, int end)
        {
            int distanceX = endX - x;
            int distanceY = y - y / 2;
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawLine(x, y, endX, endY);
            foxDraw.DrawLine(endX, endY, endX - distanceX / 2, endY / 2);
            foxDraw.DrawLine(x, y, endX - distanceX / 2, endY / 2);
            if (distanceX > 150)
                return DrawTriangle(x - (distanceX / 2), (y / 3) * 2, endX - (distanceX / 2 + distanceX / 6), (endY / 3) * 2);
            return 0;

            //private int DrawTriangle(int x, int y, int w, int h)
            //{
            //    int distanceX = w - x;
            //    var foxDraw = new FoxDraw(canvas);
            //    foxDraw.DrawLine(x, h, w, h);
            //    foxDraw.DrawLine(w, h, h, y);
            //    foxDraw.DrawLine(x, h, h, y);

            //    if (distanceX > 150)
            //        return DrawTriangle(x - (distanceX / 2), y+h/2, w-(3*x), h/2);
            //    return 0;
            //}
        }
}
        

