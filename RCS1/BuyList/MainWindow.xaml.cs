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

namespace BuyList
{
    using System.Collections.ObjectModel;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();

            BuyListItemName.Text = "Lūdzu ievadiet pirkumu";
            BuyItemsList.Add("āboli");
            BuyItemsList.Add("bumbieri");

            // šī kontrole ņems lietas un parādīs uz ekrāna
            // pasakam BuyItemsListControl, ka jāizmanto mūsu saraksts
            // kā rādāmo lietu avots (jāskatās no saraksta ko rādīt)
            BuyItemsListControl.ItemsSource = BuyItemsList;

        }

        private void AddListItemButton_Click(object sender, RoutedEventArgs e)
        {
            // izvelkam vērtību no teksta lauka
            string enteredItemToBuy = BuyListItemName.Text;

            // pēc tam nodzēšam vērtību kas parādās 
            BuyListItemName.Text = "";

            // ierakstam iegūto vērtību teksta blokā
            BuyItemsList.Add(enteredItemToBuy);
        }
    }
}
