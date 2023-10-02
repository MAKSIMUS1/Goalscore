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
    /// Логика взаимодействия для TimedMatchContentFrame.xaml
    /// </summary>
    public partial class TimedMatchContentFrame : Page
    {
        public TimedMatchContentFrame(TimedMatchWindow timedMatchWindow, MatchTimed matchTimed)
        {
            InitializeComponent();

            DataContext = new TimedMatchContentFrameViewModel(this, timedMatchWindow, matchTimed);
        }
    }
}
