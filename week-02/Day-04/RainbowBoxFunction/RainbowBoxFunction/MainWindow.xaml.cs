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


namespace RainbowBoxFunction
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
            RainbowBoxFiller(foxDraw, 50);
        }

        public void RainbowBoxFiller(FoxDraw foxDraw, int boxSize)
        {
            byte [] trueRandomColor = new [] {(byte)random.Next(63),(byte)random.Next(63,127),(byte)random.Next(127,191),(byte)random.Next(191,255)};
            byte colorFragment = trueRandomColor[random.Next(trueRandomColor.Length)];
            Color randomColor = Color.FromRgb(colorFragment, colorFragment, colorFragment);


            foxDraw.FillColor(Colors.Red);
            double x = 0.0;
            double y = 0.0;

            do
            {
                x = (foxDraw.Canvas.Width / 2) - (boxSize / 2);
                y = (foxDraw.Canvas.Height / 2) - (boxSize / 2);
                foxDraw.DrawRectangle(x, y, boxSize, boxSize);
                boxSize += 50;
                foxDraw.FillColor(randomColor);

            } while (x != 0.0);
        }
    }
}
