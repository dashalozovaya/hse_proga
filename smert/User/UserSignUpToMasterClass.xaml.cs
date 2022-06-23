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
    /// Логика взаимодействия для UserSignUpToMasterClass.xaml
    /// </summary>
    public partial class UserSignUpToMasterClass : Window
    {
        public UserSignUpToMasterClass()
        {
            InitializeComponent();

            Context db = new Context();
            List<Event> eventsList = db.Events.ToList();
            List<Event> eventNewList = new List<Event>();
            foreach (Event eventItem in eventsList)
            {
                if (eventItem.Type=="мастер-класс")
                {
                    eventNewList.Add(eventItem);
                }
            }
            Signup_mc.ItemsSource = eventNewList;
        }

        private void News_Button_Click(object sender, RoutedEventArgs e)
        {
            Admin.AdminNews adminNews = new Admin.AdminNews();
            adminNews.Show();
            this.Close();
        }

        private void Schedule_Button_Click(object sender, RoutedEventArgs e)
        {
            UserSchedule userSchedule = new UserSchedule();
            userSchedule.Show();
            this.Close();
        }

        private void Myprofile_Button_Click(object sender, RoutedEventArgs e)
        {
            UserMyProfile userMyProfile = new UserMyProfile();
            userMyProfile.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            UserMyProfile userMyProfile = new UserMyProfile();
            userMyProfile.Show();
            this.Close();
        }
    }
}
