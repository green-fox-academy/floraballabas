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

namespace CheckerBoard
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
            // fill the canvas with a checkerboard pattern.

            double x = 35;
            for (int i = 0; i < 8; i++)
            {
                double startPoint = 0+i*35;
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                            foxDraw.FillColor(Colors.White);
                        else
                            foxDraw.FillColor(Colors.Black);
                    }
                    else 
                    {
                        if (j % 2 == 0)
                            foxDraw.FillColor(Colors.Black);
                        else
                            foxDraw.FillColor(Colors.White);
                    }
                    foxDraw.DrawRectangle(0 + 35 * j, startPoint, x, x);
                }
            }
        }
    }
}
