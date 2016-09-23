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

namespace CodeMagnets
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string result = "";
            int x = 3;

            while (x > 0)
            {
                if (x > 2)
                {
                    result = result + "a";
                }

                x = x - 1;
                result = result + "-";

                if (x == 2)
                {
                    result = result + "b c";
                }

                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }
            }

            output.Text = result;
        }
    }
}
