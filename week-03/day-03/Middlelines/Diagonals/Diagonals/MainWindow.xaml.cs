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

namespace Diagonals
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
            // draw the canvas' diagonals in green.
            foxDraw.StrokeColor(Colors.Green);
            var startPoint1 = new Point(0, 0);
            var endPoint1 = new Point(500, 300);
            foxDraw.DrawLine(startPoint1, endPoint1);

            var startPoint2 = new Point(500, 0);
            var endPoint2 = new Point(0, 300);
            foxDraw.DrawLine(startPoint2, endPoint2);
        }
    }
}
