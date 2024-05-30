using Authoservices.bd;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Authoservices.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditClientService.xaml
    /// </summary>
    public partial class EditClientService : Window
    {
        bd.ServiceEntities db;
        public EditClientService(bd.ServiceEntities db, bd.ClientService clientService)
        {
            InitializeComponent();
            this.db = db;
            this.DataContext = clientService;
            identity = clientService.ID;
            List<ClientService> clients = App.serviceEntities.ClientServices.Where(x=>x.ID == identity).ToList();
        }
        int identity;
        private void EditForBaseServiceClientClick(object sender, RoutedEventArgs e)//Редактировать
        {
            try
            {
                string Data = dpDateStart.Text + tbTimeStart;
                bd.ServiceEntities db = new bd.ServiceEntities();
                int ForidClient = db.Clients.Where(x => x.FirstName == cbFirstNameClient.Text).Select(x => x.ID).FirstOrDefault();
                int ForidServiceName = db.Services.Where(x => x.Title == cbServiceName.Text).Select(x => x.ID).FirstOrDefault();
                List<ClientService> clients = App.serviceEntities.ClientServices.Where(x => x.ID == identity).ToList();
                try
                {
                    clients[0].ClientID = ForidClient;
                    clients[0].ServiceID = ForidServiceName;
                    clients[0].StartTime = Convert.ToDateTime(Data);
                    clients[0].Comment = tbComment.Text;
                }
                catch
                {
                    MessageBox.Show("Одна из строк имела неверный формат!");
                }
                App.serviceEntities.ClientServices.AddOrUpdate();
                App.serviceEntities.SaveChanges();
                MessageBox.Show("Данные успешно изменены");
                WindowServiceClient Firstwindow = new WindowServiceClient();
                Firstwindow.Show();
                this.Close();
            }
            catch { }
        }

        private void ExitClick(object sender, RoutedEventArgs e)//Выход
        {
            WindowServiceClient Firstwindow = new WindowServiceClient();
            Firstwindow.Show();
            this.Close();
        }
    }
}
