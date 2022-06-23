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

namespace smert.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminMyProfile.xaml
    /// </summary>
    public partial class AdminMyProfile : Window
    {
        public AdminMyProfile()
        {
            InitializeComponent();
        }

        private void News_button_Click(object sender, RoutedEventArgs e)
        {
            AdminNews adminNews = new AdminNews();
            adminNews.Show();
            this.Close();
        }

        private void Schedule_button_Click(object sender, RoutedEventArgs e)
        {
            AdminSchedule adminSchedule = new AdminSchedule();
            adminSchedule.Show();
            this.Close();
        }

        private void Add_mc_Click(object sender, RoutedEventArgs e)
        {
            AdminAddMasterClass adminAddMasterClass = new AdminAddMasterClass();
            adminAddMasterClass.Show();
            this.Close();
        }

        private void Add_lesson_Click(object sender, RoutedEventArgs e)
        {
            AdminAddLesson adminAddLesson = new AdminAddLesson();
            adminAddLesson.Show();
            this.Close();
        }

        private void Cancel_lesson_Click(object sender, RoutedEventArgs e)
        {
            AdminAttendance adminAttendance = new AdminAttendance();
            adminAttendance.Show();
            this.Close();
        }
    }
}
