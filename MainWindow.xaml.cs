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

namespace _312576drawingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Rectangle r = new Rectangle();
            r.Height = 100;
            r.Width = 100;
            r.Fill = Brushes.Salmon;
            canvas.Children.Add(r);
            Canvas.SetTop(r, 10);
            Canvas.SetLeft(r, 10);
        }
    }
}
