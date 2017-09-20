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

namespace LinePlayQuartet
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
            // divide the canvas into 4 parts
            // and repeat this pattern in each quarter:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/line-play/r1.png]

            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(0, 150 + i * 15, 10 + i * 15, 300);
            }
            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.MediumPurple);
                foxDraw.DrawLine(150 + i * 15, 0, 300, 10 + i * 15);
            }
            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.CadetBlue);
                foxDraw.DrawLine(300, 150 + i * 15, 300 - i *15, 300);
            }
            for (int i = 0; i < 10; i++)
            {
                foxDraw.StrokeColor(Colors.Crimson);
                foxDraw.DrawLine(0, 150 - i * 15, 10 + i * 15, 0);
            }

        }
    }
}
