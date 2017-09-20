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

namespace CenterBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            DrawSquare();

        }
        public void DrawSquare()
        {
            var foxDraw = new FoxDraw(canvas);
            for (int i = 1; i < 4; i++)
            {
                double size = 30;
                foxDraw.FillColor(Colors.Gainsboro);
                foxDraw.DrawRectangle(78+i*size, 140, size, size);
            }
        }
    }
}
