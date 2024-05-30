using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Authoservices.Pages;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Authoservices
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BaseService.ItemsSource = App.serviceEntities.Services.ToList();
        }

        public int checkActiveAdim = 0;//Проверка: включен ли режим Админа?

        private void SessiaAdminClick(object sender, RoutedEventArgs e)//Режим Админа
        {
            try
            {
                var sessiaAdmin = new WindowActivetedAdmin();
                sessiaAdmin.ShowDialog();
                if (sessiaAdmin.key == 1)//Если пароль введён вверно, то показываем кнопки 
                {
                    checkActiveAdim = 1;
                    if (checkActiveAdim == 1)
                    {
                        AddService.Visibility = Visibility.Visible;
                        FormServiceClient.Visibility = Visibility.Visible;
                        Style style = new Style//Обращаемся к стилю
                        {
                            TargetType = typeof(Grid)
                        };
                        style.Setters.Add(new Setter(Grid.VisibilityProperty, Visibility.Visible));
                        Application.Current.Resources["AdminMode"] = style;
                    }
                }
                else
                {
                    if (checkActiveAdim == 1)//Выключить режим Администратора
                    {
                        checkActiveAdim = 0;
                        if (checkActiveAdim == 0)
                        {
                            AddService.Visibility = Visibility.Hidden;
                            FormServiceClient.Visibility = Visibility.Hidden;
                            Style style = new Style
                            {
                                TargetType = typeof(Grid)
                            };
                            style.Setters.Add(new Setter(Grid.VisibilityProperty, Visibility.Hidden));
                            Application.Current.Resources["AdminMode"] = style;
                        }
                    }
                }
            }
            catch { }
        }

        private void AddServiceClick(object sender, RoutedEventArgs e)//Добавление услуги
        {
            var addServiceWindow = new WindowAddService();
            addServiceWindow.Show();
            this.Close();
        }

        private void EditServiceClick(object sender, RoutedEventArgs e)//Редактирование услуги
        {
            try
            {
                var row = BaseService.SelectedItem as bd.Service;
                if (row == null)
                {
                    MessageBox.Show("Строка не выделена для редактирования");
                }
                else
                {
                    var editServiceWindow = new WindowEditService(App.serviceEntities, row);
                    editServiceWindow.Show();
                    this.Close();
                }
            }
            catch { }
        }

        private void DeleteServiceClick(object sender, RoutedEventArgs e)//Удаление услуги
        {
            try
            {
                var row = BaseService.SelectedItem as bd.Service;
                if (row == null)
                {
                    MessageBox.Show("Строка не выделена для удаления!");
                }
                MessageBoxResult result = MessageBox.Show("Вы уверены что хотите удалить данную строку?", "Удаление!", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    App.serviceEntities.Services.Remove(row);
                    App.serviceEntities.SaveChanges();
                    MainWindow StartWindow = new MainWindow();
                    StartWindow.Show();
                    this.Close();
                }
            }
            catch { }
        }

        private void FormServiceClientClick(object sender, RoutedEventArgs e)//Окно Оформленных улуг для клиента
        {
            WindowServiceClient forServiceClient = new WindowServiceClient();
            forServiceClient.Show();
            this.Close();
        }

        private void SearchSelectionChanged(object sender, RoutedEventArgs e)//Поиск
        {
            try
            {
                string textForSearch = Search.Text;
                var goSearch = App.serviceEntities.Services.Where(x => x.Title.Contains(textForSearch)).ToList();
                BaseService.ItemsSource = goSearch;
            }
            catch { }
        }

        private void SortingSelectionChanged(object sender, SelectionChangedEventArgs e)//Сортировка
        {
            try
            {
                switch (Sorting.SelectedIndex)
                {
                    case 0:
                        BaseService.ItemsSource = App.serviceEntities.Services.ToList();
                        break;

                    case 1:
                        BaseService.ItemsSource = App.serviceEntities.Services.OrderBy(x => x.Cost).ToList(); //по возрастающей
                        break;

                    case 2:
                        BaseService.ItemsSource = App.serviceEntities.Services.OrderByDescending(x => x.Cost).ToList(); //по уменьшению
                        break;
                }
            }
            catch { }
        }

        private void FilteringSelectionChanged(object sender, SelectionChangedEventArgs e)//Фильтрация
        {
            try
            {
                switch (Filtering.SelectedIndex)
                {
                    case 0:
                        BaseService.ItemsSource = App.serviceEntities.Services.ToList();
                        break;

                    case 1:
                        BaseService.ItemsSource = App.serviceEntities.Services.Where(x => x.Discount <= 5).ToList();
                        break;

                    case 2:
                        BaseService.ItemsSource = App.serviceEntities.Services.Where(x => x.Discount >= 5 && x.Discount <= 15).ToList();
                        break;

                    case 3:
                        BaseService.ItemsSource = App.serviceEntities.Services.Where(x => x.Discount >= 15 && x.Discount <= 30).ToList();
                        break;

                    case 4:
                        BaseService.ItemsSource = App.serviceEntities.Services.Where(x => x.Discount >= 30 && x.Discount <= 70).ToList();
                        break;

                    case 5:
                        BaseService.ItemsSource = App.serviceEntities.Services.Where(x => x.Discount >= 70 && x.Discount <= 100).ToList();
                        break;
                }
            }
            catch { }
        }
    }
}
