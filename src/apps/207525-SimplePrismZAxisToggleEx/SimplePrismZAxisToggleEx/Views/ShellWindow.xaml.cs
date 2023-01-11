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
            _mainGrid.Children.Remove(_redGrid);
            _mainGrid.Children.Remove(_greenGrid);

            if (_toggleRegion)
            {
                _mainGrid.Children.Add(_redGrid);
                _mainGrid.Children.Add(_greenGrid);
            }
            else
            {
                _mainGrid.Children.Add(_greenGrid);
                _mainGrid.Children.Add(_redGrid);
            }
            _toggleRegion = !_toggleRegion;
        }
    }
}
