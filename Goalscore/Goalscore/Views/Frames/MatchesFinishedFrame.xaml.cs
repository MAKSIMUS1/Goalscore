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

namespace Goalscore.Views
{
    /// <summary>
    /// Логика взаимодействия для MatchesFinishedFrame.xaml
    /// </summary>
    public partial class MatchesFinishedFrame : Page
    {
        MainWindow window = null;
        public MatchesFinishedFrame(MatchesFrame mainWindow)
        {
            InitializeComponent();
            DataContext = new MatchesFinishedViewModel(this, window);
        }
    }
}
