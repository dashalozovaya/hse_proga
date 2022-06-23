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
    /// Логика взаимодействия для UserMyProfile.xaml
    /// </summary>
    public partial class UserMyProfile : Window
    {
        public UserMyProfile()
        {
            InitializeComponent();
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


        private void Signup_to_lesson_Click(object sender, RoutedEventArgs e)
        {
            UserSignUpToLesson userSignUpToLesson = new UserSignUpToLesson();
            userSignUpToLesson.Show();
            this.Close();
        }

        private void signup_to_mc_Click(object sender, RoutedEventArgs e)
        {
            UserSignUpToMasterClass userSignUpToMasterClass = new UserSignUpToMasterClass();
            userSignUpToMasterClass.Show();
            this.Close();
        }

        private void refuse_from_lesson_Click(object sender, RoutedEventArgs e)
        { 
            UserRefuseFromLesson userRefuseFromLesson = new UserRefuseFromLesson();
            userRefuseFromLesson.Show();
            this.Close();
        }
    }
}
