using F6MADRecipes.Class;
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

namespace F6MADRecipes.WindowsAndPages
{
    /// <summary>
    /// Логика взаимодействия для PageSignIn.xaml
    /// </summary>
    public partial class PageSignIn : Page
    {
        public PageSignIn()
        {
            InitializeComponent();
        }

        private void Btn_SignIn_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Txb_Email.Text) || string.IsNullOrEmpty(Txb_Password.Password))

            {

                MessageBox.Show("Вы не заполнили поле(я)", "Что-то не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);

            }

            else
            
            {

                if (!Txb_Email.Text.Contains("@") || string.IsNullOrWhiteSpace(Txb_Email.Text))

                {

                    MessageBox.Show("Введен некорректный Email", "Некорректный Email", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
               
                else

                {

                    try

                    {

                        var DBLogin = Class.DataBase.DBF6.User.FirstOrDefault
                            (Alien => Alien.Email == Txb_Email.Text && Alien.Password == Txb_Password.Password);

                        if (DBLogin == null)

                        {

                            MessageBox.Show("Пользователь не найден, проверьте введенные данные", "Пользователь не найден", MessageBoxButton.OK, MessageBoxImage.Warning);

                        }

                        else

                        {

                            WindowMain windowMain = new WindowMain();
                            windowMain.Show();

                        }

                    }

                    catch (Exception error)

                    {

                        MessageBox.Show("Произошла ошибка " + error.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                    }

                }
            }

        }

        private void Btn_GoSignUp_Click(object sender, RoutedEventArgs e)
        {

            Navigation.frame.Navigate(new PageSignUp());

        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {

            if(Navigation.frame.CanGoForward)

            {

                Navigation.frame.GoForward();

            }

        }
    }
}
