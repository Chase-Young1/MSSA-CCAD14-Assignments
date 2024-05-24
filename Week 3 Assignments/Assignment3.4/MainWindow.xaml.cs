using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Coffee> CoffeeList = new List<Coffee>();
        public MainWindow()
        {
            InitializeComponent();
            CoffeeListView.ItemsSource = CoffeeList;
        }
        private void AddCoffee_Click(object sender, RoutedEventArgs e)
        {

            var coffee = new Coffee
            {
                Cappuccino = this.Cappuccino.Text,
                Latte = this.Latte.Text,
                Mocha = this.Mocha.Text,
                ColdBrew = this.ColdBrew.Text
            };

            CoffeeList.Add(coffee);

            CoffeeListView.Items.Refresh();

            this.Cappuccino.Clear();
            this.Latte.Clear();
            this.Mocha.Clear();
            this.ColdBrew.Clear();
        }
    }
}