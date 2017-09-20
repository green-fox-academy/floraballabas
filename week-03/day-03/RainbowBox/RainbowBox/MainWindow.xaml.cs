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

namespace RainbowBox
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
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.
            DrawSquare();
        }
        public void DrawSquare()
        {
            var foxDraw = new FoxDraw(canvas);
            double size = 200;
            Random rnd = new Random();
            for (int i = 1; i < 10; i++)
            {
                Byte[] b = new Byte[3];
                rnd.NextBytes(b);
                Color color = Color.FromRgb(b[0], b[1], b[2]);
                foxDraw.FillColor(color);
                foxDraw.StrokeColor(color);
                foxDraw.DrawRectangle(150-(size-i*5/2), 150-(size-i*5/2), size-i*5, size-i*5);
            }

        }
    }
}
