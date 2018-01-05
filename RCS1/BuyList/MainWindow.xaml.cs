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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // @ nozīmē teksts, ignorē slīpsvītru
            File.WriteAllLines(@"C:\Users\user\Desktop\buylist_01\mans_fails.txt", BuyItemsList);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var todosFromFile = File.ReadAllLines(@"C:\Users\user\Desktop\buylist_01\mans_fails.txt");

            for (int i = 0; i < todosFromFile.Length; i++)
            {
                string currentTodo = todosFromFile[i];
                BuyItemsList.Add(currentTodo);
            }
            MessageBox.Show("all items have been loaded");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (var selectedItem in BuyItemsListControl.selectedItems)
            {
                BuyItemsList.Remove(selectedItem as string);
            }
        }
    }
}
