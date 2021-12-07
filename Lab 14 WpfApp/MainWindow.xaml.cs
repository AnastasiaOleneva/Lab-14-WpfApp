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
using System.Collections.ObjectModel;

namespace Lab_14_WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;

        public MainWindow()
        {

            InitializeComponent();
             

           products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Телевизор",
                Cost = 20000,
                Image="Data/tv.jpg",
                Category= Сategories.appliances




            });
            products.Add(new Product()
            {
                NameProduct = "Хлеб",
                Cost = 90,
                Image = "Data/bread.jpg",
                Category = Сategories.food




            });
            products.Add(new Product()
            {
                NameProduct = "Стиральная машина",
                Cost = 30000,
                Image = "Data/wm.jpg",
                Category = Сategories.appliances




            });
            lstbox.ItemsSource = products;
        }
    }
}
