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


namespace CenterBoxFunction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random;

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            random = new Random();
            DrawBoxToCenter(foxDraw, 300);
            DrawBoxToCenter(foxDraw, 200);
            DrawBoxToCenter(foxDraw, 100);
        }

        public void DrawBoxToCenter(FoxDraw foxDraw,int boxSize)
        {
            Color randomColor = Color.FromRgb((byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255));
            foxDraw.FillColor(randomColor);

            double x = (foxDraw.Canvas.Width / 2) - (boxSize / 2);
            double y = (foxDraw.Canvas.Height / 2) - (boxSize / 2);
            foxDraw.DrawRectangle(x, y, boxSize, boxSize);
        }
    }
}
