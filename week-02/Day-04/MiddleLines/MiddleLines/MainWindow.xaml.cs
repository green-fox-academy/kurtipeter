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


namespace MiddleLines
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
            DrawGreenHorizontalLine(foxDraw);
            DrawRedVerticalLine(foxDraw);
        }

        public static void DrawGreenHorizontalLine(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(foxDraw.Canvas.Width/2, 0, foxDraw.Canvas.Width / 2, foxDraw.Canvas.Height);
        }

        public static void DrawRedVerticalLine(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, foxDraw.Canvas.Height/2, foxDraw.Canvas.Width, foxDraw.Canvas.Height/2);
        }
    }
}
