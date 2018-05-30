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


namespace DrawTriangle
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
            double side = foxDraw.Canvas.Width;
            TriangleFace(foxDraw,side/2,0, side);

        }

        public void TriangleFace(FoxDraw foxDraw,double x, double y,double side)
        {
            if (side < 10)
            {
                return;
            }
            foxDraw.DrawLine(x - (side / 2), y, x + (side / 2), y);
            foxDraw.DrawLine(x + (side / 2), y ,x, y + side);
            foxDraw.DrawLine(x, y + side, x - (side / 2), y);

            foxDraw.DrawLine(x - (side / 4), y + side / 2, x + (side / 4), y + side / 2);
            foxDraw.DrawLine(x - (side / 4), y + side / 2, x, y);
            foxDraw.DrawLine(x + (side / 4), y + side / 2, x, y);

            TriangleFace(foxDraw, x-side/4,y,side/2);
            TriangleFace(foxDraw, x+side/4,y,side/2);
            TriangleFace(foxDraw, x, y + side/2, side / 2);
        }
    }
}
