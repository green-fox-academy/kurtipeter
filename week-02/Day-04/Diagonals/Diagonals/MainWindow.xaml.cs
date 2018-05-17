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


namespace Diagonals
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
            DrawDiagonals(foxDraw);

        }

        public static void DrawDiagonals(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, foxDraw.Canvas.Width, foxDraw.Canvas.Height);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(foxDraw.Canvas.Width, 0, 0, foxDraw.Canvas.Height);
        }
    }
}
