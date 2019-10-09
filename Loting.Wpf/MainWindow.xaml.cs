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

namespace Loting.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> ploegenBeschikbaar = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        void VulPloegen()
        {
            ploegenBeschikbaar.Add("Clepsy Paulas");
            ploegenBeschikbaar.Add("Siggid Stardust");
            ploegenBeschikbaar.Add("Nerdy birdies");
            ploegenBeschikbaar.Add("Outsiders");
            ploegenBeschikbaar.Add("Max Energy");
            ploegenBeschikbaar.Add("Young once");
            ploegenBeschikbaar.Add("Wonderfull Willies");
            ploegenBeschikbaar.Add("Soetigheid");
        }
    }
}
