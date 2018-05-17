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


namespace ColoredBox
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
            DrawSideOne(foxDraw);
            DrawSideTwo(foxDraw);
            DrawSideThree(foxDraw);
            DrawSideFour(foxDraw);
        }

        public static void DrawSideOne(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(10, 10, foxDraw.Canvas.Width-10, 10);
        }

        public static void DrawSideTwo(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(foxDraw.Canvas.Width - 10, 10, foxDraw.Canvas.Width-10, foxDraw.Canvas.Height - 10);
        }

        public static void DrawSideThree(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(10, 10, 10, foxDraw.Canvas.Height - 10);
        }

        public static void DrawSideFour(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(10, foxDraw.Canvas.Height - 10, foxDraw.Canvas.Width-10, foxDraw.Canvas.Height - 10);
        }
    }
}
