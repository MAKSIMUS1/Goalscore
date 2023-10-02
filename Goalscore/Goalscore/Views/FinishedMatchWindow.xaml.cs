using Goalscore.Model;
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
using System.Windows.Shapes;

namespace Goalscore.Views
{
    /// <summary>
    /// Логика взаимодействия для FinishedMatchWindow.xaml
    /// </summary>
    public partial class FinishedMatchWindow : Window
    {
        public FinishedMatchWindow(MainWindow mainWindow, MatchFinished matchFinished)
        {
            var splash = new SplashScreen("../Resources/football_field.jpg");
            splash.Show(false);
            InitializeComponent();

            DataContext = new FinishedMatchWindowViewModel(this, matchFinished);
            splash.Close(TimeSpan.FromMinutes(0));
        }
    }
}
