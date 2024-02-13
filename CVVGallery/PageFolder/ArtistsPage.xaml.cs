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
using CVVGallery.ClassFolder;

namespace CVVGallery.PageFolder
{
    /// <summary>
    /// Логика взаимодействия для ArtistsPage.xaml
    /// </summary>
    /// 

    //Grid.SetColumn(Artist1IMG, 2); изменение значения grid.column\grid.row 
    public partial class ArtistsPage : Page
    {
        public ArtistsPage()
        {
            InitializeComponent();
        }

        private void PaintingCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            Artist1IMG.Visibility = Visibility.Visible;
            Artist1faceIMG.Visibility = Visibility.Visible; 
            Artist1infoTBlock.Visibility = Visibility.Visible;
        }

        private void PaintingCheck_Checked(object sender, RoutedEventArgs e)
        {
            Artist1IMG.Visibility = Visibility.Hidden;
            Artist1faceIMG.Visibility = Visibility.Hidden;
            Artist1infoTBlock.Visibility= Visibility.Hidden;
        }

        private void AuthorsCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void AuthorsCheck_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void PrintedCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void PrintedCheck_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void CanvasCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CanvasCheck_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void PaperCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void PaperCheck_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void SilkscreenCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SilkscreenCheck_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void AbstractionCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void AbstractionCheck_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void FigurativeCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void FigurativeCheck_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void StreeArtCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void StreeArtCheck_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
