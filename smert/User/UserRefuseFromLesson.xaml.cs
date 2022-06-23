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

namespace smert.User
{
    /// <summary>
    /// Логика взаимодействия для UserRefuseFromLesson.xaml
    /// </summary>
    public partial class UserRefuseFromLesson : Window
    {
        public UserRefuseFromLesson()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            UserMyProfile userMyProfile = new UserMyProfile();
            userMyProfile.Show();
            this.Close();
        }

        private void News_button_Click(object sender, RoutedEventArgs e)
        {
            Admin.AdminNews adminNews = new Admin.AdminNews();
            adminNews.Show();
            this.Close();
        }

        private void Schedule_button_Click(object sender, RoutedEventArgs e)
        {
            UserSchedule userSchedule = new UserSchedule();
            userSchedule.Show();
            this.Close();
        }

        private void Myprofile_button_Click(object sender, RoutedEventArgs e)
        {
            UserMyProfile userMyProfile = new UserMyProfile();
            userMyProfile.Show();
            this.Close();
        }
    }
}
