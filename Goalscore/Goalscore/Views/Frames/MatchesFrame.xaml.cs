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
    /// Логика взаимодействия для MatchesFrame.xaml
    /// </summary>
    public partial class MatchesFrame : Page
    {
        public MatchesFrame(MainWindow mainWindow)
        {
            InitializeComponent();
            DataContext = new MatchesFrameViewModel(this, mainWindow);
        }
    }
}
