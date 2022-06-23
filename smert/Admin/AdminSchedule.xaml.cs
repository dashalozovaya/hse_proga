using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace smert.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminSchedule.xaml
    /// </summary>
    public partial class AdminSchedule : Window
    {
        public AdminSchedule()
        {
            InitializeComponent();

            Context db = new Context();
            List<Event> eventsList = db.Events.ToList();
            ScheduleAdmin.ItemsSource = eventsList;
        }


        private void News_button_Click(object sender, RoutedEventArgs e)
        {
            AdminNews adminNews = new AdminNews();
            adminNews.Show();
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
            Context db = new Context();

            Event eventToRemove = (Event)ScheduleAdmin.SelectedItem;

            db.Events.Remove(eventToRemove);
        }
    }
}
