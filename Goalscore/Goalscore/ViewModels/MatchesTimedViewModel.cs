using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FootballDataApi.Models;
using Goalscore.Commands;
using Goalscore.Model;
using Goalscore.Views;

namespace Goalscore.ViewModels
{
    public class MatchesTimedViewModel : FrameViewModel<MatchesTimedFrame, MainWindow>
    {
        private ObservableCollection<MatchTimed> matches;
        public ObservableCollection<MatchTimed> Matches
        {
            get => matches;
            set
            {
                matches = value;
                OnPropertyChanged("Matches");
            }
        }
        private ObservableCollection<MatchTimed> originalMathces;

        MainWindow mainWindow;
        public MatchesTimedViewModel(MatchesTimedFrame owner, MainWindow window) : base(owner, window)
        {
            mainWindow = window;
            matches = new ObservableCollection<MatchTimed>();
            originalMathces = new ObservableCollection<MatchTimed>();
            var timedTeams = from m in DataBase.DataBaseManager.Instance.matchSet
                             join c in DataBase.DataBaseManager.Instance.competitionSet on m.CompetitionId equals c.Id
                             join a in DataBase.DataBaseManager.Instance.areaSet on c.AreaId equals a.Id
                             where m.Status == "TIMED"
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
                                 AreaName = a.Name
                             };

            var mdf = DataBase.DataBaseManager.Instance.matchSet.Join(DataBase.DataBaseManager.Instance.competitionSet,
                p => p.CompetitionId, // Match
                c => c.Id, // Competition
                (p, c) => new
                {
                    MatchId = p.Id,
                    CompetitionName = c.Name,
                    UtcDate = p.UtcDate,
                    Status = p.Status,
                    HomeTeamId = p.HomeTeamId,
                    AwayTeamId = p.AwayTeamId,
                    ScoreId = p.ScoreId,
                    RefereeId = p.RefereeId,
                    LastUpdated = p.LastUpdated
                });
            foreach (var i in timedTeams)
            {
                if (i.HomeTeamId == null || i.AwayTeamId == null || i.RefereeId == null)
                { continue; }
                else
                {
                    originalMathces.Add(new MatchTimed(i.MatchId, i.CompetitionName, i.UtcDate, i.Status, i.HomeTeamId, i.AwayTeamId, i.ScoreId, i.RefereeId, i.LastUpdated, i.AreaName));
                    matches.Add(new MatchTimed(i.MatchId, i.CompetitionName, i.UtcDate, i.Status, i.HomeTeamId, i.AwayTeamId, i.ScoreId, i.RefereeId, i.LastUpdated, i.AreaName));
                }
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
                      TimedMatchWindow timedMatchWindow = new TimedMatchWindow(mainWindow, Matches[SelectedIndex]);
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
                          List<MatchTimed> lstPr = new List<MatchTimed>();
                          foreach (MatchTimed pr in originalMathces)
                              lstPr.Add(pr);
                          var listItog = from p in lstPr
                                         where p.HomeTeamName.Contains(Owner.SearchBox.Text) || p.AwayTeamName.Contains(Owner.SearchBox.Text)
                                         select p;
                          ObservableCollection<MatchTimed> SearchedMathces = new ObservableCollection<MatchTimed>();
                          foreach (MatchTimed p in listItog)
                              SearchedMathces.Add(p);
                          Matches = SearchedMathces;
                      }
                  }));
            }
        }
    }
}