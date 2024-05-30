using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Логика взаимодействия для WindowAddService.xaml
    /// </summary>
    public partial class WindowAddService : Window
    {
        public WindowAddService()
        {
            InitializeComponent();
        }

        private void AddForBaseServiceClick(object sender, RoutedEventArgs e)//Добавить услугу
        {
            try
            {
                int SerachNameServiceInBD = App.serviceEntities.Services.Where(x=>x.Title == NameService.Text).Select(x=>x.ID).FirstOrDefault();//Для проверки на существующую услугу
                if (SerachNameServiceInBD == null)
                {
                    bd.ServiceEntities db = new bd.ServiceEntities();
                    bd.Service service = new bd.Service()
                    {
                        Title = NameService.Text,
                        Cost = Convert.ToDecimal(CountService.Text),
                        DurationInSeconds = Convert.ToInt32(TimeService.Text),
                        Discount = Convert.ToInt32(DiscountService.Text),
                    };
                    db.Services.Add(service);
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно добавлены!");
                    MainWindow FirstWindow = new MainWindow();
                    FirstWindow.checkActiveAdim = 1;
                    FirstWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Данная услуга уже существует в списке!");
                }
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
