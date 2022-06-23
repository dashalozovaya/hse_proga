﻿using System;
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
    /// Логика взаимодействия для AdminAttendance.xaml
    /// </summary>
    public partial class AdminAttendance : Window
    {
        public AdminAttendance()
        {
            InitializeComponent();

            Context db = new Context();
            List<Event> eventsList = db.Events.ToList();
            EventAttendanceListBox.ItemsSource = eventsList;
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AdminMyProfile adminMyProfile = new AdminMyProfile();
            adminMyProfile.Show();
            this.Close();
        }
    }
}
