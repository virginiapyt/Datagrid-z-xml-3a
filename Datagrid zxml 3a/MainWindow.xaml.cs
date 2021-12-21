using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Xml.Linq;

namespace Datagrid_zxml_3a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string plik1 = @"..\..\Dane\produkty.xml"; //plik zrodlowy
        private XElement wykazProduktow;
        public ObservableCollection<string> magazyny { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists(plik1))
                wykazProduktow = XElement.Load(plik1);
            else
                MessageBox.Show("nie ma pliku");
            
            gridprodukty.DataContext = wykazProduktow;

            magazyny = new ObservableCollection<string>()
            { "Katowice_m1", "Gliwice_m2", "Zabrze_m3"};
            kombo.ItemsSource = magazyny;
        }
    }
}
