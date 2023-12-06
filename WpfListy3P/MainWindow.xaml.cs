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
        }
    }
}
