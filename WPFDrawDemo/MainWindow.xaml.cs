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

namespace WPFDrawDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            drawGrid();
        }

        private void drawGrid()
        {
            var centerX = this.Width/2;
            var centerY = this.Height/2;
            double diePieth = 30;
            double R = 100;
            double dieLen = 0;
            SolidColorBrush gridBrush = new SolidColorBrush();
            gridBrush.Color = Colors.Red;

            while (dieLen <= R)
            {
                double lineLen = System.Math.Sqrt(R * R - System.Math.Pow(dieLen, 2));
                Line aa = new Line();
                aa.X1 = centerX - lineLen;
                aa.Y1 = centerY + dieLen;
                aa.X2 = centerX + lineLen;
                aa.Y2 = centerY + dieLen;
                aa.Stroke = gridBrush;
                aa.StrokeThickness = 1;
                this.myGrid.Children.Add(aa);

                Line bb = new Line();
                bb.X1 = centerX - lineLen;
                bb.Y1 = centerY - dieLen;
                bb.X2 = centerX + lineLen;
                bb.Y2 = centerY - dieLen;
                bb.Stroke = gridBrush;
                bb.StrokeThickness = 1;
                this.myGrid.Children.Add(bb);

                Line cc = new Line();
                cc.X1 = centerX - dieLen;
                cc.Y1 = centerY - lineLen;
                cc.X2 = centerX - dieLen;
                cc.Y2 = centerY + lineLen;
                cc.Stroke = gridBrush;
                cc.StrokeThickness = 1;
                this.myGrid.Children.Add(cc);

                Line dd = new Line();
                dd.X1 = centerX + dieLen;
                dd.Y1 = centerY - lineLen;
                dd.X2 = centerX + dieLen;
                dd.Y2 = centerY + lineLen;
                dd.Stroke = gridBrush;
                dd.StrokeThickness = 1;
                this.myGrid.Children.Add(dd);




                dieLen += diePieth;
            }
        }
    }
}
