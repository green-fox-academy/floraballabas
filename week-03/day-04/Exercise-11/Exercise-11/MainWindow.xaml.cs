﻿using System;
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

namespace Exercise_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Fractals();
            
        }

        private void Fractals()
        {
            double size = 100;
            var foxdraw = new FoxDraw(canvas);
            for (int i = 0; i < 3; i++)
            {
                double startPoint = 0 + i * 100;
                for (int j = 0; j < 3; j++)
                {
                    foxdraw.DrawRectangle(0+j*100, startPoint, size, size);
                }
            }
        }
    }
}
