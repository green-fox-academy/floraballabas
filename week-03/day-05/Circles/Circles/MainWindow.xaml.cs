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

namespace Circles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int x = 0;
            int y = 0;
            int diameter = 300;
            DrawCircles(x, y, diameter);

        }
        public void DrawCircles(int x, int y, int diameter)
        {
            var foxdraw = new FoxDraw(canvas);

            foxdraw.BackgroundColor(Colors.Beige);
            foxdraw.FillColor(Color.FromArgb(0, 255, 255, 255));
            foxdraw.DrawEllipse(x, y, diameter, diameter);
            foxdraw.DrawEllipse(x+(diameter*0.25), y, diameter/2, diameter/2);
            foxdraw.DrawEllipse(x +(diameter * 0.05), y+(diameter*0.4), diameter / 2, diameter / 2);
            foxdraw.DrawEllipse(x + (diameter * 0.45), y + (diameter * 0.4), diameter / 2, diameter / 2);
        }
       
    }
}
