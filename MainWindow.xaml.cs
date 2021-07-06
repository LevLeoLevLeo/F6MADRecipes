using F6MADRecipes.Class;
using F6MADRecipes.DataBase;
using F6MADRecipes.WindowsAndPages;
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

namespace F6MADRecipes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            Class.DataBase.DBF6 = new F6MADRecipesEntities();
            Navigation.frame = Frm_Authorization;
            Navigation.frame.Navigate(new PageSignIn());

        }
    }
}
