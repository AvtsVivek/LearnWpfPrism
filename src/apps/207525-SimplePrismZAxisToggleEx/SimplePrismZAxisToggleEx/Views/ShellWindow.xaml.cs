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
            AddElements();
            
        }
        private void AddElements()
        {
            //MainGrid.Children.Clear();
            //var firstRowDefinition = new RowDefinition { Height = GridLength.Auto };
            //MainGrid.RowDefinitions.Add(firstRowDefinition);
            //var secondRowDefinition = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };
            //MainGrid.RowDefinitions.Add(secondRowDefinition);

            //var button = new Button { Height = 40 };
            //MainGrid.Children.Add(button);
            //button.Content = "here we go ...";

            //Grid.SetRow(button, 0);

            var redContentControl = new ContentControl();
            RegionManager.SetRegionName(redContentControl, "RedRegion");
            // var redGrid = new Grid();
            _redGrid.Children.Add(redContentControl);

            MainGrid.Children.Add(_redGrid);
            Grid.SetRow(_redGrid, 1);

            var greenContentControl = new ContentControl();
            RegionManager.SetRegionName(greenContentControl, "GreenRegion");
            //var greenGrid = new Grid();
            _greenGrid.Children.Add(greenContentControl);

            MainGrid.Children.Add(_greenGrid);
            
            Grid.SetRow(_greenGrid, 1);

        }

        private Grid _redGrid = new Grid();
        private Grid _greenGrid = new Grid();
        private bool _toggleRegion = false;

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Remove(_redGrid);
            MainGrid.Children.Remove(_greenGrid);

            if (_toggleRegion)
            {
                MainGrid.Children.Add(_redGrid);
                MainGrid.Children.Add(_greenGrid);
            }
            else
            {
                MainGrid.Children.Add(_greenGrid);
                MainGrid.Children.Add(_redGrid);
            }
            _toggleRegion = !_toggleRegion;
        }
    }
}
