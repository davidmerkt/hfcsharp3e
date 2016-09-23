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

namespace PoolPuzzle
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            string poem = "";

            while (x < 4)
            {
                poem = poem + "a"; 
                if (x < 1)
                {
                    poem += " "; 
                }
                
                poem += "n";

                if (x > 1)
                {
                    poem += " oyster";
                    x += 2;
                }

                if (x == 1)
                {
                    poem += "noys ";
                }

                if (x < 1)
                {
                    poem += "oise ";
                }

                x += 1;
            }

            output.Text = poem;
        }
    }
}
