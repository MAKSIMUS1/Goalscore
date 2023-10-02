using Goalscore.Commands;
using Goalscore.Model;
using Goalscore.Views;
using Goalscore.Views.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Goalscore.ViewModels
{
    public class FinishedMatchWindowViewModel : WindowViewModel<FinishedMatchWindow>
    {
        private FinishedMatchContentInfo fmcINFO;
        private FinishedMatchContentLineup fmcLineup;
        private FinishedMatchContentSquad fmcSquad;
        public FinishedMatchWindowViewModel(FinishedMatchWindow owner, MatchFinished match) : base(owner)
        {
            LoadWindow ld = new LoadWindow();
            fmcINFO = new FinishedMatchContentInfo(owner, match);
            fmcLineup = new FinishedMatchContentLineup(owner, match);
            fmcSquad = new FinishedMatchContentSquad(owner, match);
            owner.TimeMatchTextBlock.Text = match.HomeTeamScore.ToString() + " - " + match.AwayTeamScore.ToString();
            var homeImageSource = new Uri(DataBase.DataBaseManager.GetTeamImageSource(match.HomeTeam.Id), UriKind.RelativeOrAbsolute);
            Owner.HomeTeamImage.Source = new BitmapImage(homeImageSource);
            var awayImageSource = new Uri(DataBase.DataBaseManager.GetTeamImageSource(match.AwayTeam.Id), UriKind.RelativeOrAbsolute);
            Owner.AwayTeamImage.Source = new BitmapImage(awayImageSource);
            DateTime d = (DateTime)match.UtcDate;
            Owner.ScoreMatchTextBlock.Text = d.ToShortDateString();
        }

        private RelayCommand compositionCommand;
        public RelayCommand CompositionCommand
        {
            get
            {
                return compositionCommand ??
                  (compositionCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          Owner.ContentFrame.Content = fmcSquad;
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand placementCommand;
        public RelayCommand PlacementCommand
        {
            get
            {
                return placementCommand ??
                  (placementCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          Owner.ContentFrame.Content = fmcLineup;
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand informationCommand;
        public RelayCommand InformationCommand
        {
            get
            {
                return informationCommand ??
                  (informationCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          Owner.ContentFrame.Content = fmcINFO;
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
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
