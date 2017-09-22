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

namespace Triangles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawTriangle(200, 280, 300, 280);

        }
        public void DrawTriangle(int x, int y, int endX, int endY)
        {
            int distanceX = endX - x;
            var foxDraw = new FoxDraw(canvas);
            foxDraw.DrawLine(x, y, endX, endY);
            foxDraw.DrawLine(endX, endY, endX - distanceX / 2, (y/3)*2);
            foxDraw.DrawLine(x, y, endX - distanceX / 2, (y / 3) * 2);
        }

    }
}
