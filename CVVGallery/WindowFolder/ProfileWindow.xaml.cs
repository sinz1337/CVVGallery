using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net;
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
using CVVGallery.ClassFolder;
using CVVGallery.PageFolder;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Navigation;
using System.Windows.Media.Animation;
using System.Xml.Linq;
using System.Windows.Threading;

namespace CVVGallery.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        

        public ProfileWindow()
        {
            InitializeComponent();
        }

        private void ExitIMG_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MBClass.ExitMB();
        }

        private void BinIMG_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new BinPage());
        }

        private void FavoritesIMG_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new FavoritePage());
        }

        private void TgIMG_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://t.me/d0uluvme");
        }

        private void ProfileIMG_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new ProfilePage());
        }

        private void PaintingLB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new PaintingPage());
        }

        private void GraphicLB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new GraphicPage());
        }

        private void ArtistsLB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new ArtistsPage());
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private bool _allowDirectNavigation = false;
        private NavigatingCancelEventArgs _navArgs = null;
        private Duration _duration = new Duration(TimeSpan.FromSeconds(0.3));
        private double _oldHeight = 0;


        private void MainFrame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (Content != null && !_allowDirectNavigation)
            {
                e.Cancel = true;

                _navArgs = e;
                _oldHeight = MainFrame.ActualHeight;

                DoubleAnimation animation0 = new DoubleAnimation();
                animation0.From = MainFrame.ActualHeight;
                animation0.To = 0;
                animation0.Duration = _duration;
                animation0.Completed += SlideCompleted;
                MainFrame.BeginAnimation(HeightProperty, animation0);
            }
            _allowDirectNavigation = false;
        }

        private void SlideCompleted(object sender, EventArgs e)
        {
            _allowDirectNavigation = true;
            switch (_navArgs.NavigationMode)
            {
                case NavigationMode.New:
                    if (_navArgs.Uri == null)
                        MainFrame.Navigate(_navArgs.Content);
                    else
                        MainFrame.Navigate(_navArgs.Uri);
                    break;
                case NavigationMode.Back:
                    MainFrame.GoBack();
                    break;
                case NavigationMode.Forward:
                    MainFrame.GoForward();
                    break;
                case NavigationMode.Refresh:
                    MainFrame.Refresh();
                    break;
            }

            Dispatcher.BeginInvoke(DispatcherPriority.Loaded,
                (ThreadStart)delegate ()
                {
                    DoubleAnimation animation0 = new DoubleAnimation();
                    animation0.From = 0;
                    animation0.To = _oldHeight;
                    animation0.Duration = _duration;
                    MainFrame.BeginAnimation(HeightProperty, animation0);
                });
        }

    }
}
