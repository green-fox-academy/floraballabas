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

namespace Tapestry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            double boxSize = ((canvas.Width + canvas.Height) / 6);
            double x = 167;
            double y = 167;

            DrawTapestry(x, y, boxSize, boxSize);
        }
        public double DrawTapestry(double x, double y, double size1, double size2)
        {
            double totalSize = (size1 + size2)/2;
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Beige);
            foxDraw.FillColor(Colors.Black);
            foxDraw.DrawRectangle(x, y, size1, size2);
            if (totalSize > 10)
            {
                DrawTapestry(x - (totalSize*0.5), y - (totalSize*0.6), size1/4, size2/4);
            }
            return 0;
        }
    }
}
