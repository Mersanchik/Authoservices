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
using System.Windows.Shapes;

namespace Authoservices.Pages
{
    /// <summary>
    /// Логика взаимодействия для WindowServiceClient.xaml
    /// </summary>
    public partial class WindowServiceClient : Window
    {
        public WindowServiceClient()
        {
            InitializeComponent();
            BaseClientService.ItemsSource = App.serviceEntities.ClientServices.ToList();
        }

        private void AddServiceClientClick(object sender, RoutedEventArgs e)//Добавление услуги для клиента
        {
            AddClientService addClientService = new AddClientService();
            addClientService.Show();
            this.Close();
        }

        private void FormServiceClick(object sender, RoutedEventArgs e)//Окно Улуг 
        {
            MainWindow Firstwindow = new MainWindow();
            Firstwindow.checkActiveAdim = 1;
            Firstwindow.Show();
        }

        private void SortingClick(object sender, RoutedEventArgs e)//сортировка по свежим  записям
        {
            BaseClientService.ItemsSource = App.serviceEntities.ClientServices.OrderByDescending(x => x.StartTime).ToList(); 
        }
    }
}
