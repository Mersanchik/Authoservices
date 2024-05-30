using Authoservices.bd;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Principal;
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
    /// Логика взаимодействия для WindowEditService.xaml
    /// </summary>
    public partial class WindowEditService : Window
    {
        bd.ServiceEntities db;
        public WindowEditService(bd.ServiceEntities db, bd.Service service)
        {
            InitializeComponent();
            this.db = db;
            this.DataContext = service;
            identity = service.ID;
            List<Service> services = App.serviceEntities.Services.Where(x => x.ID == identity).ToList();
        }
        int identity;

        private void EditForBaseServiceClick(object sender, RoutedEventArgs e)//Редактировать
        {
            try
            {
                List<Service> services = App.serviceEntities.Services.Where(x => x.ID == identity).ToList();
                try
                {
                    services[0].Title = NameService.Text;
                    services[0].Cost = Convert.ToDecimal(CountService.Text);
                    services[0].DurationInSeconds = Convert.ToInt32(TimeService.Text);
                    services[0].Discount = Convert.ToInt32(DiscountService.Text);
                }
                catch
                {
                    
                }
                App.serviceEntities.Services.AddOrUpdate();
                App.serviceEntities.SaveChanges();
                MessageBox.Show("Данные успешно изменены!");
                MainWindow FirstWindow = new MainWindow();
                FirstWindow.checkActiveAdim = 1;
                FirstWindow.Show();
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Одна из строк имела неверный формат!");
            }
        }

        private void ExitClick(object sender, RoutedEventArgs e)//Выход
        {
            MainWindow Firstwindow = new MainWindow();
            Firstwindow.checkActiveAdim = 1;
            Firstwindow.Show();
            this.Close();
        }
    }
}
