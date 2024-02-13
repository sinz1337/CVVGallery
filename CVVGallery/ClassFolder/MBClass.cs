using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CVVGallery.ClassFolder
{
    internal class MBClass
    {
        public static void ErrorMB(string text)
        {
            MessageBox.Show(text, "Ошибка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
        public static void ErrorMB(Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }

        public static void InfoMB(string text)
        {
            MessageBox.Show(text, "Информация",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        public static bool QuestionMB(string text)
        {
            return MessageBoxResult.Yes ==
                 MessageBox.Show(text, "Выход",
                 MessageBoxButton.YesNo,
                 MessageBoxImage.Question);
        }

        public static void ExitMB()
        {
            bool result = QuestionMB("Вы действительно хотите выйти?");
            if (result == true)
            {
                App.Current.Shutdown();
            }
        }
    }
}
