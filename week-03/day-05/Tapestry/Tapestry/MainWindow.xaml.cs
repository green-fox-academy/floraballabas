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
            double x = 166;
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
            if (totalSize > 1)
            {
                DrawTapestry(x - (totalSize * 0.69), y - (totalSize * 0.65), size1 / 3, size2 / 3);
                DrawTapestry(x - (totalSize * 0.69), y + (totalSize * 0.32), size1 / 3, size2 / 3);
                DrawTapestry(x - (totalSize * 0.69), y + (totalSize * 1.30), size1 / 3, size2 / 3);
                DrawTapestry(x + (totalSize * 0.32), y + (totalSize * 1.30), size1 / 3, size2 / 3);
                DrawTapestry(x + (totalSize * 1.35), y + (totalSize * 1.30), size1 / 3, size2 / 3);
                DrawTapestry(x + (totalSize * 1.35), y + (totalSize * 0.32), size1 / 3, size2 / 3);
                DrawTapestry(x + (totalSize * 1.35), y - (totalSize * 0.65), size1 / 3, size2 / 3);
                DrawTapestry(x + (totalSize * 0.32), y - (totalSize * 0.65), size1 / 3, size2 / 3);
            }
            return 0;
        }
    }
}
