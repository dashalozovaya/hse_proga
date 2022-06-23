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

namespace smert
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Signin_Button_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show(); 
            this.Close();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        { 
            Admin.AdminMyProfile adminMyProfile = new Admin.AdminMyProfile();
            adminMyProfile.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User.UserMyProfile userMyProfile = new User.UserMyProfile();
            userMyProfile.Show();
            this.Close();
        }
    }
}
