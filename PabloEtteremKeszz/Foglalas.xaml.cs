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

namespace PabloEtteremKeszz
{
    /// <summary>
    /// Interaction logic for Foglalas.xaml
    /// </summary>
        public partial class Foglalas : Window
        {
            public static List<string> Foglalasok = new List<string>();

            public Foglalas()
            {
                InitializeComponent();
            }

            private void Foglalas_Click(object sender, RoutedEventArgs e)
            {
                string nev = txtNev.Text;
                string idopont = txtIdopont.Text;
                string asztal = cbAsztalok.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(nev) || string.IsNullOrWhiteSpace(idopont) || asztal == null)
                {
                    MessageBox.Show("Minden mezőt ki kell tölteni!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                string foglalas = $"{nev} - {idopont} - Asztal: {asztal}";
                Foglalasok.Add(foglalas);
                MessageBox.Show("Sikeres foglalás!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
}
