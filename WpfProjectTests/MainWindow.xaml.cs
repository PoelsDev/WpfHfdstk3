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

namespace WpfProjectTests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void knop2_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hallo wereld!", "Hallo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
        }

        private void knop1_Click(object sender, RoutedEventArgs e)
        {
            double top = 0;
            double left = 0;

            top = mijnRechthoek.Margin.Top;
            left = mijnRechthoek.Margin.Left;

            left++;

            mijnRechthoek.Stroke = Brushes.BlueViolet;
            mijnRechthoek.Margin = new Thickness(left, top, 0, 0);
        }

        private void knop3_Click(object sender, RoutedEventArgs e)
        {
            Line Lijn = new Line();
            Lijn.X1 = 35;
            Lijn.Y1 = 4;
            Lijn.X2 = 76;
            Lijn.Y2 = 190;
            Lijn.Stroke = new SolidColorBrush(Colors.DarkSalmon);
            mijnCanvas.Children.Add(Lijn);
        }

        private void knop4_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse1 = new Ellipse();
            ellipse1.Width = 50;
            ellipse1.Height = 50;
            ellipse1.Margin = new Thickness(10, 10, 0, 0);
            ellipse1.Stroke = new SolidColorBrush(Colors.PaleVioletRed);
            ellipse1.Fill = Brushes.Purple;
            mijnCanvas.Children.Add(ellipse1);
        }
    }
}
