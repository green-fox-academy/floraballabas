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

namespace PurpleSteps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]
            DrawSquares();
        }

        public void DrawSquares()
        {
            var foxDraw = new FoxDraw(canvas);
            double size = 10;
            for (int i = 0; i < 15; i++)
            {
                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(0+i*size, 0+i*size, size, size);

            }
        }
    }
}
