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

namespace WpfListy3P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<String> ListaSlow { get; set; }
        public List<Produkt> Produkty { get; set; }
        public MainWindow()
        {
            ListaSlow = new List<String>();
            ListaSlow.Add("programisci"); 
            ListaSlow.Add("nie"); 
            ListaSlow.Add("obijają"); 
            ListaSlow.Add("się"); 
            ListaSlow.Add("nawet"); 
            ListaSlow.Add("w"); 
            InitializeComponent();
            DataContext = this;
            lista3.ItemsSource = ListaSlow;
            przygotujDane();
        }
        private void przygotujDane()
        {
            Produkty = new List<Produkt>();
            Produkty.Add(new Produkt("klocki", 34.99, "plastikowe ", true));
            Produkty.Add(new Produkt("miś", 59.99, "milutki ", true));
            Produkty.Add(new Produkt("autko", 4.99, "szybkie ", true));
            Produkty.Add(new Produkt("samolot", 44, "", false));
        }
    }
}
