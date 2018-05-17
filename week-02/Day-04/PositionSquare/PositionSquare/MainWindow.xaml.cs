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


namespace PositionSquare
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
            DrawSquareInPosition(foxDraw, 0,0);
            DrawSquareInPosition(foxDraw, 150,150);
            DrawSquareInPosition(foxDraw, 243,62);
        }

        public static void DrawSquareInPosition(FoxDraw foxDraw, int x, int y)
        {
            Random rnd = new Random();
            for (int i = 1; i < 4 + 1; i++)
            {
                foxDraw.FillColor(Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));

                foxDraw.DrawRectangle(x, y, 50, 50);
            }
        }
    }
}

