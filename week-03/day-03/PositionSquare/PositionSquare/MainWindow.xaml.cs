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

namespace PositionSquare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function. 
            DrawSquare();
        }
        public void DrawSquare()
        {
            var foxDraw = new FoxDraw(canvas);
            for (int i = 1; i < 4; i++)
            {
                double x = 10 + i * 50;
                double y = 10 + i * 50;

                foxDraw.FillColor(Colors.ForestGreen);
                foxDraw.DrawRectangle(x, y, 50, 50);
            }
        }
    }
}
