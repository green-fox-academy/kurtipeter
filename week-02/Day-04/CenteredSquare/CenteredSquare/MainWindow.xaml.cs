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


namespace CenteredSquare
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
            DrawASquare(foxDraw);

        }
        public static void DrawASquare(FoxDraw foxDraw)
        { 
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(foxDraw.Canvas.Width / 2 - 5, foxDraw.Canvas.Height / 2 -5, foxDraw.Canvas.Width / 2 - 5, foxDraw.Canvas.Height / 2 + 5);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(foxDraw.Canvas.Width / 2 - 5, foxDraw.Canvas.Height / 2 - 5, foxDraw.Canvas.Width / 2 + 5, foxDraw.Canvas.Height / 2 - 5);

            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(foxDraw.Canvas.Width / 2 + 5, foxDraw.Canvas.Height / 2 - 5, foxDraw.Canvas.Width / 2 + 5, foxDraw.Canvas.Height / 2 + 5);
        
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(foxDraw.Canvas.Width / 2 - 5, foxDraw.Canvas.Height / 2 + 5, foxDraw.Canvas.Width / 2 + 5, foxDraw.Canvas.Height / 2 + 5);
        }
    }
}
