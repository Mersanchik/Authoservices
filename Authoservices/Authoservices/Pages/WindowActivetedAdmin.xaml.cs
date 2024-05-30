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
    /// Логика взаимодействия для WindowActivetedAdmin.xaml
    /// </summary>
    public partial class WindowActivetedAdmin : Window
    {
        public WindowActivetedAdmin()
        {
            InitializeComponent();
        }

        public int key;
        private void OpenSessiaAdministratorClick(object sender, RoutedEventArgs e)//Проверить пароль от аккаунта администратора
        {
            try
            {
                if (PasswordAdmin.Text == "0000")
                {
                    key = 1;
                    MessageBox.Show("Режим администратора активирован!");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Пароль неверен!");
                    key = 0;
                }
            }
            catch { }
        }
    }
}
