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

namespace VlasowPr419k
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Scenarist_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Scenarist.Text.Length < 10 || Scenarist.Text.Length > 40)
            {
                Scenarist.Background = Brushes.Red;
                string text = "Плохо";
                textsms.Text = text;

            }
            else
            {
                Scenarist.Background = Brushes.Green;
                string text1 = "Хорошо";
                textsms.Text = text1;
            }

        }


        private void Hudoz_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Hudoz.Text.Length < 10 || Hudoz.Text.Length > 40)
            {
                Hudoz.Background = Brushes.Red;
                string text = "Плохо";
                textsms1.Text = text;

            }
            else
            {
                Hudoz.Background = Brushes.Green;
                string text1 = "Хорошо";
                textsms1.Text = text1;
            }
        }

        private void Izdatel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Izdatel.Text.Length < 2 || Izdatel.Text.Length > 15)
            {
                Izdatel.Background = Brushes.Red;
                string text = "Плохо";
                textsms2.Text = text;

            }
            else
            {
                Izdatel.Background = Brushes.Green;
                string text1 = "Хорошо";
                textsms2.Text = text1;
            }
        }


        private void NomWipusk_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            {
                if (!char.IsDigit(e.Text, e.Text.Length - 1) || (NomWipusk.Text == "" && e.Text == "-"))
                {
                    e.Handled = true;
                }
            }

        }
    }
}

