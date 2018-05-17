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


namespace Draw4Rectangle
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
            DrawSomeRectangle(foxDraw, 4);
        }

        public static void DrawSomeRectangle(FoxDraw foxDraw, int numberOfRectangles)
        {
            Random rnd = new Random();
            int position = 0;
            for (int i = 1; i < numberOfRectangles+1; i++)
            {
                foxDraw.FillColor(Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));

                foxDraw.DrawRectangle(position -1, position -1, i *50, i * 50);
                position += i * 50;
            }
        }
    }
}
