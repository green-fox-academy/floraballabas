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

namespace FunctionsToCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.
            LineDrawing();

        }
        public void LineDrawing()
        {
            
            var foxDraw = new FoxDraw(canvas);
            double x = 0;
            double y = 0;

            for (int i = 0; i <= 300; i+=20)
            {
                foxDraw.DrawLine(i, y, 150, 150);
            }
            for (int j = 0; j <= 300; j+=20)
            {
                foxDraw.DrawLine(300, j, 150, 150);
            }
            for (int k = 0; k <= 300; k+=20)
            {
                foxDraw.DrawLine(k, 300, 150, 150);
            }
            for (int m = 0; m <= 300; m+=20)
            {
                foxDraw.DrawLine(x, m, 150, 150);
            }

        }
    }
}
