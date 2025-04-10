﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PabloEtteremKeszz
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
        private void bt_Etlap_Click(object sender, RoutedEventArgs e)
        {
            Etlap etlapWindow = new Etlap();
            etlapWindow.Show();
        }

        private void bt_Borlap_Click(object sender, RoutedEventArgs e)
        {
            Borlap etlapWindow = new Borlap();
            etlapWindow.Show();
        }
        private void ComboBox_Valtozik(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                if (comboBox.SelectedItem is ComboBoxItem selectedItem)
                {
                    switch (selectedItem.Content.ToString())
                    {
                        case "Asztalfoglalás":
                            new Foglalas().ShowDialog();
                            break;
                        case "Foglalás Lemondása":
                            MessageBox.Show("Ez a funkció később lesz elérhető!", "Info");
                            break;
                        case "Rendelés":
                            MessageBox.Show("Ez a funkció később lesz elérhető!", "Info");
                            break;
                        case "Számla Készítése":
                            MessageBox.Show("Ez a funkció később lesz elérhető!", "Info");
                            break;
                    }
                }
            }
        }
    }
}