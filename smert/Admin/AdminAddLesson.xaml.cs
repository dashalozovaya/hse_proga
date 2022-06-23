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
    /// Логика взаимодействия для AdminAddLesson.xaml
    /// </summary>
    public partial class AdminAddLesson : Window
    {
        Context db;

        public AdminAddLesson()
        {
            InitializeComponent();

            db = new Context();
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AdminMyProfile adminMyProfile = new AdminMyProfile();
            adminMyProfile.Show();
            this.Close();
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

        private void Myprofile_button_Click(object sender, RoutedEventArgs e)
        {
            AdminMyProfile adminMyProfile = new AdminMyProfile();
            adminMyProfile.Show();
            this.Close();
        }

        private void Cancel_button_Click(object sender, RoutedEventArgs e)
        {
            string style = StyleEvent.Text;
            string date = DateEvent.Text;
            string time = TimeEvent.Text;
            string teacher = TeacherEvent.Text;
            string type = "занятие";

            Event newevent = new Event(style, date, time, teacher, type);
            

            db.Events.Add(newevent);
            db.SaveChanges();

            MessageBox.Show($"Занятие по {style} на {date} успешно добавлено!");
        }
    }
}
