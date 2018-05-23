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


namespace Triangles
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
            DrawMultiTriangle(foxDraw, 100);
        }

        public void DrawMultiTriangle(FoxDraw foxDraw, int number)
        {
            int width = (int)foxDraw.Canvas.Width / number;
            int height = (int)foxDraw.Canvas.Height / number;
            int consHalf = (int)foxDraw.Canvas.Width / number / 2;
            
            for (int j = 0; number > j; j++)
            {
                for (int i = 0; i < (number - j); i++)
                {
                    foxDraw.DrawLine
                    (
                        width * i + j * consHalf,
                        height * (number-j),
                        width * i + width + j * consHalf,
                        height * (number - j)
                    );

                    foxDraw.DrawLine
                    (
                        width * i + width + j * consHalf,
                        height * (number - j),
                        width * i + consHalf + j * consHalf,
                        height * (number - j - 1)
                    );

                    foxDraw.DrawLine
                    (
                        width * i  + consHalf + j * consHalf,
                        height * (number - j - 1),
                        width * i + j *consHalf,
                        height * (number - j)
                    );
                }
            }
        }
    }
}
