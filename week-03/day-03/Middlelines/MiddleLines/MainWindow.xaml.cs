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

namespace MiddleLines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.StrokeColor(Colors.Red);
            var startPoint1 = new Point(0, 150);
            var endPoint1 = new Point(500, 150);
            foxDraw.DrawLine(startPoint1, endPoint1);

            foxDraw.StrokeColor(Colors.Green);
            var startPoint2 = new Point(250, 0);
            var endPoint2 = new Point(250, 300);
            foxDraw.DrawLine(startPoint2, endPoint2);
        }
    }
}
