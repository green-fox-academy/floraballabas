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
            double x = 0;
            double y = 0;
            double diameter = (canvas.Width+canvas.Height)/2;
            
            DrawCircles(x, y, diameter);

        }
        public double DrawCircles(double x, double y, double diameter)
        {
            var foxdraw = new FoxDraw(canvas);
            Random rnd = new Random();
            Byte[] b = new Byte[3];
            rnd.NextBytes(b);
            Color color = Color.FromRgb(b[0], b[1], b[2]);

            foxdraw.BackgroundColor(Colors.Beige);
            foxdraw.FillColor(Color.FromArgb(0, 255, 255, 255));
            foxdraw.DrawEllipse(x, y, diameter, diameter);
            foxdraw.DrawEllipse(x+(diameter*0.25), y, diameter/2, diameter/2);
            foxdraw.DrawEllipse(x +(diameter * 0.05), y+(diameter*0.4), diameter / 2, diameter / 2);
            foxdraw.FillColor(color);
            foxdraw.DrawEllipse(x + (diameter * 0.45), y + (diameter * 0.4), diameter / 2, diameter / 2);
            if (diameter > 50)
            {
                DrawCircles(x + (diameter / 2.7), y, diameter / 4);
                DrawCircles(x + (diameter * 0.26), y + (diameter * 0.18), diameter / 4);
                DrawCircles(x + (diameter * 0.49), y + (diameter * 0.18), diameter / 4);
                DrawCircles(x + (diameter * 0.18), y+(diameter*0.4), diameter / 4);
                DrawCircles(x + (diameter * 0.06), y + (diameter * 0.58), diameter / 4);
                DrawCircles(x + (diameter * 0.29), y + (diameter * 0.58), diameter / 4);
                DrawCircles(x + (diameter * 0.57), y + (diameter * 0.4), diameter / 4);
                DrawCircles(x + (diameter * 0.46), y + (diameter * 0.58), diameter / 4);
                DrawCircles(x + (diameter * 0.69), y + (diameter * 0.58), diameter / 4);
            }
            return 0;
                
        }
       
    }
}
