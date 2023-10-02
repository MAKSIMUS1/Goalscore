using Goalscore.Commands;
using Goalscore.Model;
using Goalscore.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Goalscore.ViewModels
{
    public class MatchesFinishedViewModel : FrameViewModel<MatchesFinishedFrame, MainWindow>
    {
        private ObservableCollection<MatchFinished> matches;
        public ObservableCollection<MatchFinished> Matches
        {
            get => matches;
            set
            {
                matches = value;
                OnPropertyChanged("Matches");
            }
        }
        private ObservableCollection<MatchFinished> originalMathces;
        public MatchesFinishedViewModel(MatchesFinishedFrame owner, MainWindow window) : base(owner, window)
        {
            matches = new ObservableCollection<MatchFinished>();
            originalMathces = new ObservableCollection<MatchFinished>();
            var timedTeams = from m in DataBase.DataBaseManager.Instance.matchSet
                             join c in DataBase.DataBaseManager.Instance.competitionSet on m.CompetitionId equals c.Id
                             join a in DataBase.DataBaseManager.Instance.areaSet on c.AreaId equals a.Id
                             where m.Status == "FINISHED"
                             select new
                             {
                                 MatchId = m.Id,
                                 CompetitionName = c.Name,
                                 UtcDate = m.UtcDate,
                                 Status = m.Status,
                                 HomeTeamId = m.HomeTeamId,
                                 AwayTeamId = m.AwayTeamId,
                                 ScoreId = m.ScoreId,
                                 RefereeId = m.RefereeId,
                                 LastUpdated = m.LastUpdated,
                                 AreaName = a.Name,
                                 Attendance = m.Attendance
                             };
            foreach (var i in timedTeams)
            {
                originalMathces.Add(new MatchFinished(i.MatchId, i.CompetitionName, i.UtcDate, i.Status, i.HomeTeamId, i.AwayTeamId, i.ScoreId, i.RefereeId, i.LastUpdated, i.AreaName, i.Attendance));
                matches.Add(new MatchFinished(i.MatchId, i.CompetitionName, i.UtcDate, i.Status, i.HomeTeamId, i.AwayTeamId, i.ScoreId, i.RefereeId, i.LastUpdated, i.AreaName, i.Attendance));
            }
        }

        private RelayCommand homeTeamCommand;
        public RelayCommand HomeTeamCommand
        {
            get
            {
                return homeTeamCommand ??
                  (homeTeamCommand = new RelayCommand(obj =>
                  {
                      MessageBox.Show("Hello");
                  }));
            }
        }
        private RelayCommand showMatchCommand;
        public RelayCommand ShowMatchCommand
        {
            get
            {
                return showMatchCommand ??
                  (showMatchCommand = new RelayCommand(obj =>
                  {
                      FinishedMatchWindow timedMatchWindow = new FinishedMatchWindow(OwnerWindow, Matches[SelectedIndex]);
                      timedMatchWindow.ShowDialog();
                  }));
            }
        }
        private int _selectedIndex;

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                if (_selectedIndex == value)
                    return;

                _selectedIndex = value;
                OnPropertyChanged("SelectedIndex");
            }
        }

        private RelayCommand searchCommand;
        public RelayCommand SearchCommand
        {
            get
            {
                return searchCommand ??
                  (searchCommand = new RelayCommand(obj =>
                  {
                      if (string.IsNullOrEmpty(Owner.SearchBox.Text))
                      {
                          Matches = originalMathces;
                      }
                      else
                      {
                          List<MatchFinished> lstPr = new List<MatchFinished>();
                          foreach (MatchFinished pr in originalMathces)
                              lstPr.Add(pr);
                          var listItog = from p in lstPr
                                         where p.HomeTeamName.Contains(Owner.SearchBox.Text) || p.AwayTeamName.Contains(Owner.SearchBox.Text)
                                         select p;
                          ObservableCollection<MatchFinished> SearchedMathces = new ObservableCollection<MatchFinished>();
                          foreach (MatchFinished p in listItog)
                              SearchedMathces.Add(p);
                          Matches = SearchedMathces;
                      }
                  }));
            }
        }
    }
}
