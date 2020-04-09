using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ThreadsInWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool blend1Running = false;
        public bool blend2Running = false;
        public MainWindow()
        {
            InitializeComponent();

            StopBtn1.IsEnabled = false;
            StopBtn2.IsEnabled = false;
        }

        private void BtnPutIn1_Click(object sender, RoutedEventArgs e)
        {
            if (lbFruits.SelectedItem != null)
            {
                var fruit = (lbFruits.SelectedItem as ListBoxItem).Content;
                lbBlender1.Items.Add(new ListBoxItem { Content = fruit });
            }
        }

        private void BtnPutIn2_Click(object sender, RoutedEventArgs e)
        {
            if (lbFruits.SelectedItem != null)
            {
                var fruit = (lbFruits.SelectedItem as ListBoxItem).Content;
                lbBlender2.Items.Add(new ListBoxItem { Content = fruit });
            }
        }

        private void BtnBlend1_Click(object sender, RoutedEventArgs e)
        {
            new Thread(Blend1).Start();
            btnBlend1.IsEnabled = false;
            blend1Running = true;
            StopBtn1.IsEnabled = true;
        }

        private void BtnBlend2_Click(object sender, RoutedEventArgs e)
        {
            new Thread(Blend2).Start();
            btnBlend2.IsEnabled = false;
            blend1Running = true;
            StopBtn2.IsEnabled = true;
        }

        private void Blend1()
        {
            
            int blendTime = 10;
            int i = 0;

            while (blend1Running == true && i > blendTime)
            {
                Dispatcher.Invoke(() => lblStatus2.Content = i);
                Thread.Sleep(1000);
                
            }
            i++;
            Dispatcher.Invoke(() =>
                {
                    lblStatus1.Content = "Juice Ready";
                    Dispatcher.Invoke(() => btnBlend1.IsEnabled = true);

                });
            
        }

        private void Blend2()
        {
            
            int blendTime = 10;
            int i = 0;

            while (blend2Running == true && i > blendTime)
                {
                    Dispatcher.Invoke(() => lblStatus2.Content = i);
                    Thread.Sleep(1000);
                    
                }
            i++;

            Dispatcher.Invoke(() => {
                lblStatus1.Content = "Juice Ready";
                Dispatcher.Invoke(() => btnBlend2.IsEnabled = true);

            });
        }

        private void Clean1_Click(object sender, RoutedEventArgs e)
        {
            new Thread(Clean1).Start();
            lbBlender1.Items.Clear();
            Clean1Btn.IsEnabled = false;

        }

        private void Clean2_Click(object sender, RoutedEventArgs e)
        {
            new Thread(Clean2).Start();
            lbBlender2.Items.Clear();
            Clean2Btn.IsEnabled = false;

        }

        public void Clean1()
        {
            int cleanTime = 10;
            for (int i = 0; i < cleanTime; i++)
            {
                Dispatcher.Invoke(() => lblStatus1.Content = "Cleaning " + i);
                Thread.Sleep(1000);
            }
            Dispatcher.Invoke(() => {
                lblStatus1.Content = "Cleaned!";
                Dispatcher.Invoke(() => Clean1Btn.IsEnabled = true);

            });
        }

        public void Clean2()
        {
            int cleanTime = 10;
            for (int i = 0; i < cleanTime; i++)
            {
                Dispatcher.Invoke(() => lblStatus2.Content = "Cleaning " + i);
                Thread.Sleep(1000);
            }
            Dispatcher.Invoke(() => {
                lblStatus2.Content = "Cleaned!";
                Dispatcher.Invoke(() => Clean2Btn.IsEnabled = true);

            });
        }

        private void StopBtn1_Click(object sender, RoutedEventArgs e)
        {
            StopBtn1.IsEnabled = false;
            blend1Running = false;
            lblStatus1.Content = "Stopped";
        }

        private void StopBtn2_Click(object sender, RoutedEventArgs e)
        {
            StopBtn2.IsEnabled = false;
            blend2Running = false;
            lblStatus2.Content = "Stopped";
        }
    }

}
