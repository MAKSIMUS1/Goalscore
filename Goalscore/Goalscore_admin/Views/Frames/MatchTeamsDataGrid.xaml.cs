using Goalscore_admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Goalscore_admin.Views.Frames
{
    /// <summary>
    /// Логика взаимодействия для MatchTeamsDataGrid.xaml
    /// </summary>
    public partial class MatchTeamsDataGrid : Page
    {
        public MatchTeamsDataGrid(MainWindow mainWindow)
        {
            InitializeComponent();

            DataContext = new MatchTeamsDataGridViewModel(this, mainWindow);
        }
    }
}
