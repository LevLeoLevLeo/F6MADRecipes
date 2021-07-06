using F6MADRecipes.Class;
using F6MADRecipes.DataBase;
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
    /// Логика взаимодействия для PageSignUp.xaml
    /// </summary>
    public partial class PageSignUp : Page
    {
        public PageSignUp()
        {
            InitializeComponent();
        }

        private void Btn_SignUp_Click(object sender, RoutedEventArgs e)
        {

            try

            {

                if (string.IsNullOrEmpty(Txb_NewEmail.Text) || string.IsNullOrEmpty(Txb_NewPassword.Password) || string.IsNullOrEmpty(Txb_Name.Text) || string.IsNullOrEmpty(Txb_NewRePassword.Password))

                {

                    MessageBox.Show("Вы не заполнили поле(я)", "Что-то не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);

                }

                else
                {

                    if (!Txb_NewEmail.Text.Contains("@") || string.IsNullOrWhiteSpace(Txb_NewEmail.Text))

                    {

                        MessageBox.Show("Введен некорректный Email", "Некорректный Email", MessageBoxButton.OK, MessageBoxImage.Warning);

                    }

                    else

                    {

                        if (Txb_NewPassword.Password != Txb_NewRePassword.Password)

                        {

                            MessageBox.Show("Пароли не совпадают, попробуйте еще раз", "Пароль", MessageBoxButton.OK, MessageBoxImage.Warning);

                        }

                        else

                        {

                            var DBReg = Class.DataBase.DBF6.User.FirstOrDefault
                                (Alien => Alien.Email == Txb_NewEmail.Text);

                            if (DBReg != null)

                            {

                                MessageBox.Show("Данная почта уже зарегистрированна, пожалуйста, введите другую", "Email", MessageBoxButton.OK, MessageBoxImage.Warning);

                            }
                            
                            else

                            {

                                User user = new User()

                                    {

                                        Name = Txb_Name.Text,
                                        Email = Txb_NewEmail.Text,
                                        Password = Txb_NewPassword.Password,


                                    };

                                Class.DataBase.DBF6.User.Add(user);
                                Class.DataBase.DBF6.SaveChanges();
                                Navigation.frame.Navigate(new PageSignIn());
                                MessageBox.Show("Вы зарегестрированы!", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);

                            }
                        }
                    }
                }
            }
        
            catch

            {



            }


        }
            private void Btn_Back_Click(object sender, RoutedEventArgs e)

            {

                Navigation.frame.GoBack();

            }

    } 
}
