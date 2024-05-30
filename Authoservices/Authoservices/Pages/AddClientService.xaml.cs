using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для AddClientService.xaml
    /// </summary>
    public partial class AddClientService : Window
    {
        public AddClientService()
        {
            InitializeComponent();
            cbFirstNameClient.ItemsSource = App.serviceEntities.Clients.Select(c => c.FirstName).ToList();
            cbServiceName.ItemsSource = App.serviceEntities.Services.Select(x=>x.Title).ToList();
        }

        private void AddForBaseServiceClientClick(object sender, RoutedEventArgs e)//Добавление
        {
            try
            {
                bd.ServiceEntities db = new bd.ServiceEntities();
                int ForidClient = db.Clients.Where(x => x.FirstName == cbFirstNameClient.Text).Select(x => x.ID).FirstOrDefault();
                int ForidServiceName = db.Services.Where(x => x.Title == cbServiceName.Text).Select(x => x.ID).FirstOrDefault();
                bd.ClientService clientService = new bd.ClientService()
                {
                    ClientID = ForidClient,
                    ServiceID = ForidServiceName,
                    StartTime = Convert.ToDateTime(dpDateStart.Text + " " + tbTimeStart.Text),
                    Comment = tbComment.Text
                };
                db.ClientServices.Add(clientService);
                db.SaveChanges();
                MessageBox.Show("Данные успешно добавены!");
                WindowServiceClient Firstwindow = new WindowServiceClient();
                Firstwindow.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Одана из строк имела неверный формат!");
            }
        }

        private void ExitClick(object sender, RoutedEventArgs e)//Выход
        {
            WindowServiceClient Firstwindow = new WindowServiceClient();
            Firstwindow.Show();
            this.Close();
        }
    }
}
