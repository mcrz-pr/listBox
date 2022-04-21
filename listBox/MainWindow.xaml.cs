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

namespace listBox
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

           private void all(object sender, RoutedEventArgs e)
            {
            int x = 0;

            if (zolte.IsChecked == true) x++;
            if (czerwone.IsChecked == true) x++;
            if (zielone.IsChecked == true) x++;
            if (biale.IsChecked == true) x++;
            if (rozowe.IsChecked == true) x++;
            if (niebieskie.IsChecked == true) x++;

            progres.Value = x;
        }
        
        }
}
