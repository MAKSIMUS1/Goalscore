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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Goalscore.Views.Frames
{
    /// <summary>
    /// Логика взаимодействия для FinishedMatchContentSquad.xaml
    /// </summary>
    public partial class FinishedMatchContentSquad : Page
    {
        public FinishedMatchContentSquad(FinishedMatchWindow fihishedMatchWindow, MatchFinished matchFinished)
        {
            InitializeComponent();

            DataContext = new FinishedMatchContentSquadViewModel(this, fihishedMatchWindow, matchFinished);
        }
    }
}
