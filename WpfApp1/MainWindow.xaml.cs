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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        zaimEntities Add { get; set; }
        Class1 class1;
        public MainWindow()
        {
            Add = new zaimEntities();
            InitializeComponent();
            class1 = new Class1();  
            Zaim.ItemsSource = Add.Zaim.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var genRazr = class1.Generate();
            Add.Zaim.Add(genRazr);
            var Dob12222 = new dobr(Add, genRazr);
            Dob12222.ShowDialog();
            
        }

      
    }
}
