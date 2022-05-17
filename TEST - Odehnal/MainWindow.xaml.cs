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

namespace TEST___Odehnal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        nakladak tatra;

        public MainWindow()
        {
            InitializeComponent();

            tatra = new nakladak();
            txt1.Text = tatra.ToString();
            Shownakladak(tatra, txt1);
        }
        public void Shownakladak(nakladak nakladak, TextBox textbox )
        {
            textbox.Text = $"Maximalni Nosnost: {nakladak.MaxNosnost}¨\n";
            textbox.Text += $"Naklad: {nakladak.Naklad }\n";
            textbox.Text += $"Velikost Nadrze: {nakladak.VelikostNadrze}\n";
            textbox.Text += $"Stav Paliva: {nakladak.StavPaliva}\n";
            textbox.Text += $"Stav Tachometr: {nakladak.StavTachometr}\n";
            textbox.Text += $"Spotreba Paliva: {nakladak.SpotrebaPaliva}\n";

        }

    }
}
