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

namespace WPF
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
            MessageBox.Show("PECORINO TOSCANO GRIGLIATO CON NOCI CARAMELLIZZATE E PERA\r\nSU INSALATINA DI FARRO E VERDURE (1,8,9)\r\n\r\nGrillezett toszkán juhsajt karamellizált dióval, körtével és tönkölybúzás zöldségsalátával\r\n5.450,-Ft");
        }

        private void bt_Borlap_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}