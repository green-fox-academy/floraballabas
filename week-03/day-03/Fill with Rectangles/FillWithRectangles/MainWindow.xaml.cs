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

namespace FillWithRectangles
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
            // draw four different size and color rectangles.
            foxDraw.FillColor(Colors.LawnGreen);
            foxDraw.DrawRectangle(10, 10, 90, 70);

            foxDraw.FillColor(Colors.LemonChiffon);
            foxDraw.DrawRectangle(100, 80, 50, 20);

            foxDraw.FillColor(Colors.MediumOrchid);
            foxDraw.DrawRectangle(160, 110, 80, 50);

            foxDraw.FillColor(Colors.Crimson);
            foxDraw.DrawRectangle(250, 170, 40, 30);
        }
    }
}
