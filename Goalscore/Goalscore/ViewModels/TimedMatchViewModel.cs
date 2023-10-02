using Goalscore.Commands;
using Goalscore.Views;
using Goalscore.Views.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Goalscore.ViewModels
{
    public class TimedMatchViewModel : WindowViewModel<TimedMatchWindow>
    {
        public MatchTimed match;
        public TimedMatchViewModel(TimedMatchWindow owner, MatchTimed match) : base(owner)
        {
            this.match = match;
            var f = this.match.HomeTeamName;
            Owner.HomeTeamImage.Source = DataBase.DataBaseManager.GetTeamImage(this.match.HomeTeam.Id);
            Owner.AwayTeamImage.Source = DataBase.DataBaseManager.GetTeamImage(this.match.AwayTeam.Id);
            Owner.TimeMatchTextBlock.Text = this.match.UtcDate.ToString();
            Owner.ContentFrame.Content = new TimedMatchContentFrame(Owner, this.match);
        }

        private RelayCommand closeWindowCommand;
        public RelayCommand CloseWindowCommand
        {
            get
            {
                return closeWindowCommand ??
                  (closeWindowCommand = new RelayCommand(obj =>
                  {
                      Owner.Close();
                  }));
            }
        }
    }
}
