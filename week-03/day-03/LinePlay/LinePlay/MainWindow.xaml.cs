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

namespace LinePlay
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
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/line-play/r1.png]

            var w = canvas.Width;
            var h = canvas.Height;

            for (int i = 20; i < 300; i += 20)
            {
                var x = i * w / (300 - 20);
                var y = i * h / (300 - 20);
                foxDraw.StrokeColor(Colors.LimeGreen);
                foxDraw.DrawLine(0, y, x, h);
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(x, 0, w, y);
            }
        }
    }
}
