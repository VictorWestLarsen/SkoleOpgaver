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

namespace InteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        Controller controller = Controller.GetInstance();
        public MainWindow()
        {
            InitializeComponent();
            UpdateIndexAndCount();
            ButtonStatus();
        }

        private void ButtonStatus()
        {
            if (controller.PersonCount == 0)
            {
                NewPersonBtn.IsEnabled = true;
                DltPersonBtn.IsEnabled = false;
                DownBtn.IsEnabled = false;
                UpBtn.IsEnabled = false;
                TelephoneNoBox.IsEnabled = false;
                AgeBox.IsEnabled = false;
                LastnameBox.IsEnabled = false;
                FirstnameBox.IsEnabled = false;
            }
            else
            {
                NewPersonBtn.IsEnabled = true;
                DltPersonBtn.IsEnabled = true;
                DownBtn.IsEnabled = true;
                UpBtn.IsEnabled = true;
                TelephoneNoBox.IsEnabled = true;
                AgeBox.IsEnabled = true;
                LastnameBox.IsEnabled = true;
                FirstnameBox.IsEnabled = true;
            }

        }


        private void DownBtn_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            UpdateIndexAndCount();
            UpdatePersonInfo();
        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            UpdateIndexAndCount();
            UpdatePersonInfo();

        }

        private void DltPersonBtn_Click(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
            UpdateIndexAndCount();

        }

        private void NewPersonBtn_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            UpdateIndexAndCount();
            ButtonStatus();
            ClearAll();
        }

        private void UpdateIndexAndCount()
        {
            IndexCounter.Content = controller.PersonIndex;
            PersonCounter.Content = controller.PersonCount;
        }

        private void FirstnameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.FirstName = FirstnameBox.Text;

        }

        private void LastnameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.LastName = FirstnameBox.Text;
        }

        private void AgeBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.Age = int.Parse(AgeBox.Text);

        }

        private void TelephoneNoBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.TelephoneNo = TelephoneNoBox.Text;
        }

        private void ClearAll()
        {
            FirstnameBox.Text = "";
            LastnameBox.Text = "";
            AgeBox.Text = "0";
            TelephoneNoBox.Text = "";
        }

        public void UpdatePersonInfo()
        {
            FirstnameBox.Text = controller.CurrentPerson.FirstName;
            LastnameBox.Text = controller.CurrentPerson.LastName;
            AgeBox.Text = controller.CurrentPerson.Age + "";
            TelephoneNoBox.Text = controller.CurrentPerson.TelephoneNo;
        }
    }
}
