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

namespace U2Graphics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            

            InitializeComponent();


            myGrid.Children.Add(createLine(30, 30, 10, 100));
            myGrid.Children.Add(createLine(30, 30, 30, 80));

            // Add a Line Element
            Line myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myLine.X1 = 1;
            myLine.X2 = 50;
            myLine.Y1 = 1;
            myLine.Y2 = 50;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 20;
            myGrid.Children.Add(myLine);

            Line coolLine = new Line();
            coolLine.Stroke = System.Windows.Media.Brushes.Chocolate;
            coolLine.X1 = 10;
            coolLine.X2 = 10;
            coolLine.Y1 = 5;
            coolLine.Y2 = 50;
            coolLine.StrokeThickness = 5;
            myGrid.Children.Add(coolLine);

            int k = 5;
            for(int i = 0; i < k; i++)
            {
                drawsquare(65, 65 + k * 50, 10, 65);
            }

        }

        private void drawsquare(int v1, int v2, int v3, int v4)
        {

        }

        private Line createLine(double v1, double v2, double v3, double v4)
        {
            // Add a Line Element
            Line myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myLine.X1 = v1;
            myLine.X2 = v2;
            myLine.Y1 = v3;
            myLine.Y2 = v4;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 20;
            return myLine;

        }
    }
}
