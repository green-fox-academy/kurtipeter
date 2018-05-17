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


namespace HorizontalLines
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
            DrawLines(foxDraw, 3);

        }

        public static void DrawAHorizontalLine(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(x, y, x +50, y);
        }

        public static void DrawLines(FoxDraw foxDraw, int numberOfLines)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                DrawAHorizontalLine(foxDraw, i * 40, i * 75);
            }
        }
    }
}
