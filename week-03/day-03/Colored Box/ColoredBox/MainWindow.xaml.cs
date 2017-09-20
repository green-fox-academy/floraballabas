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

namespace ColoredBox
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
            // draw a box that has different colored lines on each edge.
            foxDraw.StrokeColor(Colors.ForestGreen);
            var startPoint1 = new Point(20, 20);
            var endPoint1 = new Point(100, 20);
            foxDraw.DrawLine(startPoint1, endPoint1);

            foxDraw.StrokeColor(Colors.Purple);
            var startPoint2 = new Point(100, 20);
            var endPoint2 = new Point(100, 100);
            foxDraw.DrawLine(startPoint2, endPoint2);

            foxDraw.StrokeColor(Colors.DeepSkyBlue);
            var startPoint3 = new Point(100, 100);
            var endPoint3 = new Point(20, 100);
            foxDraw.DrawLine(startPoint3, endPoint3);

            foxDraw.StrokeColor(Colors.Chocolate);
            var startPoint4 = new Point(20, 100);
            var endPoint4 = new Point(20, 20);
            foxDraw.DrawLine(startPoint4, endPoint4);
        }
    }
}
