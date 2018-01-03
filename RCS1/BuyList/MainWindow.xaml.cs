using System;
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

namespace BuyList
{
    using System.Collections.ObjectModel;
    using System.IO;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();

            BuyListItemName.Text = "lūdzu ievadiet pirkumu";
            BuyItemsList.Add("āboli");
            BuyItemsList.Add("bumbieri");

            // pasakam BuyItemsListControl, ka jāizmanto mūsu saraksts,
            // kā rādāmo lietu avots (jāskatās no saraksta, ko rādīt)
            BuyItemsListControl.ItemsSource = BuyItemsList;
        }

        private void AddListItemButton_OnClick(object sender, RoutedEventArgs e)
        {
            // izvelkam vērtību no teksta lauka
            string input = BuyListItemName.Text;

            // nodzēšam vērtību teksta laukā
            BuyListItemName.Text = "";

            // ierakstām ieguto vērtību teksta blokā
            BuyItemsList.Add(input);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines(@"C:\_fails.txt", BuyItemsList);
        }
    }
}
