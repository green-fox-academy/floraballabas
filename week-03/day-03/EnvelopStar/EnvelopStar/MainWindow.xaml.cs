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

namespace EnvelopStar
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

            for (int i = 0; i < 15; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(150, 0 + i * 10, 150 + i * 10, 150);
            }
            for (int i = 0; i < 15; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(150, 300 - i * 10, 150 - i * 10, 150);
            }
            for (int i = 0; i < 15; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(150, 0 + i * 10, 150 - i * 10, 150);
            }
            for (int i = 0; i < 15; i++)
            {
                foxDraw.StrokeColor(Colors.Lime);
                foxDraw.DrawLine(150, 300 - i * 10, 150 + i * 10, 150);
            }

        }
    }
}
