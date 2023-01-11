using Prism.Regions;
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
using System.Windows.Shapes;

namespace SimplePrismZAxisToggleEx.Views
{
    /// <summary>
    /// Interaction logic for ShellWindow.xaml
    /// </summary>
    public partial class ShellWindow : Window
    {
        public ShellWindow()
        {
            InitializeComponent();
        }

        private bool _toggleRegion = false;

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Remove(redGrid);
            MainGrid.Children.Remove(greenGrid);

            if (_toggleRegion)
            {
                MainGrid.Children.Add(redGrid);
                MainGrid.Children.Add(greenGrid);
            }
            else
            {
                MainGrid.Children.Add(greenGrid);
                MainGrid.Children.Add(redGrid);
            }
            _toggleRegion = !_toggleRegion;
        }
    }
}
