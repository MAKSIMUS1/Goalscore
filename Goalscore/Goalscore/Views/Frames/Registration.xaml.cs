using Goalscore.ViewModels;
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

namespace Goalscore.Views.Frames
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        AuthorizationWindow AuthorizationWindow;
        public Registration(AuthorizationWindow authorizationWindow)
        {
            InitializeComponent();
            AuthorizationWindow = authorizationWindow;
            DataContext = new RegistrationViewModel(this, AuthorizationWindow);
        }
    }
}
