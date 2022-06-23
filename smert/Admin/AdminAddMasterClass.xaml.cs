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
    /// Логика взаимодействия для AdminAddMasterClass.xaml
    /// </summary>
    public partial class AdminAddMasterClass : Window
    {
        Context db;
        public AdminAddMasterClass()
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

        private void News_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminNews adminNews = new AdminNews();
            adminNews.Show();
            this.Close();
        }

        private void Schedule_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminSchedule adminSchedule = new AdminSchedule();
            adminSchedule.Show();
            this.Close();
        }

        private void Myprofile_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminMyProfile adminMyProfile = new AdminMyProfile();
            adminMyProfile.Show();
            this.Close();
        }

        private void MasterClassConfirm_Button_Click(object sender, RoutedEventArgs e)
        {
            string style = StyleMasterClass_TextBox.Text;
            string date = DateMasterClass_TextBox.Text;
            string time = TimeMasterClass_TextBox.Text;
            string teacher = TeacherMasterClass_TextBox.Text;
            string type = "мастер-класс";

            Event newevent = new Event(style, date, time, teacher, type);

            db.Events.Add(newevent);
            db.SaveChanges();

            MessageBox.Show($"Мастер-класс по {style} на {date} успешно добавлен!");
        }
    }
}
