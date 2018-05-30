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


namespace SuperHexagon
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
            DrawAHexagon(foxDraw, 200, 200, 50);

        }

        public void DrawAHexagon(FoxDraw foxDraw, double x, double y, double size)
        {
            double hexSize = size;
            double halfSize = size / 2;
            double halfHeight = Math.Sqrt(3) / 2 * size;

            var points = new List<Point>();
            points.Add(new Point(x, y));
            points.Add(new Point(x + halfSize, y - halfHeight));
            points.Add(new Point(x + halfSize + hexSize, y - halfHeight));
            points.Add(new Point(x + 2 * hexSize, y));
            points.Add(new Point(x + halfSize + hexSize, y + halfHeight));
            points.Add(new Point(x + halfSize, y + halfHeight));
            points.Add(new Point(x, y));

            foxDraw.FillColor(Colors.White);
            foxDraw.DrawPolygon(points);
        }
    }
}
