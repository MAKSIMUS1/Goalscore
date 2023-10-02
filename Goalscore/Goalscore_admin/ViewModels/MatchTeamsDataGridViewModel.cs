using FootballDataApi.Models;
using Goalscore.Commands;
using Goalscore.DataBase;
using Goalscore.ViewModels;
using Goalscore_admin.Views.Frames;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goalscore_admin.ViewModels
{
    public class MatchTeamsDataGridViewModel : FrameViewModel<MatchTeamsDataGrid, MainWindow>
    {
        public MatchTeamsDataGridViewModel(MatchTeamsDataGrid owner, MainWindow window) : base(owner, window)
        {
        }

        private ObservableCollection<MatchTeam> matchTeams;
        private RelayCommand matchTeamsDataGridCommand;
        public RelayCommand MatchTeamsDataGridCommand
        {
            get
            {
                return matchTeamsDataGridCommand ??
                  (matchTeamsDataGridCommand = new RelayCommand(obj =>
                  {
                      matchTeams = new ObservableCollection<MatchTeam>();
                      foreach (var i in DataBaseManager.Instance.matchTeamSet.ToList())
                      {
                          matchTeams.Add(i);
                      }
                      Owner.MainDataGrid.ItemsSource = matchTeams;
                  }));
            }
        }

        private ObservableCollection<Match> matches;
        private RelayCommand matchesDataGridCommand;
        public RelayCommand MatchesDataGridCommand
        {
            get
            {
                return matchesDataGridCommand ??
                  (matchesDataGridCommand = new RelayCommand(obj =>
                  {
                      matches = new ObservableCollection<Match>();
                      foreach (var i in DataBaseManager.Instance.matchSet.ToList())
                      {
                          matches.Add(i);
                      }
                      Owner.MainDataGrid.ItemsSource = matches;
                  }));
            }
        }
        private ObservableCollection<Competition> competitions;
        private RelayCommand competitionsDataGridCommand;
        public RelayCommand CompetitionsDataGridCommand
        {
            get
            {
                return competitionsDataGridCommand ??
                  (competitionsDataGridCommand = new RelayCommand(obj =>
                  {
                      competitions = new ObservableCollection<Competition>();
                      foreach (var i in DataBaseManager.Instance.competitionSet.ToList())
                      {
                          competitions.Add(i);
                      }
                      Owner.MainDataGrid.ItemsSource = competitions;
                  }));
            }
        }
        private ObservableCollection<Area> areas;
        private RelayCommand areasDataGridCommand;
        public RelayCommand AreasDataGridCommand
        {
            get
            {
                return areasDataGridCommand ??
                  (areasDataGridCommand = new RelayCommand(obj =>
                  {
                      areas = new ObservableCollection<Area>();
                      foreach (var i in DataBaseManager.Instance.areaSet.ToList())
                      {
                          areas.Add(i);
                      }
                      Owner.MainDataGrid.ItemsSource = areas;
                  }));
            }
        }

        private ObservableCollection<Season> seasons;
        private RelayCommand seasonsDataGridCommand;
        public RelayCommand SeasonsDataGridCommand
        {
            get
            {
                return seasonsDataGridCommand ??
                  (seasonsDataGridCommand = new RelayCommand(obj =>
                  {
                      seasons = new ObservableCollection<Season>();
                      foreach (var i in DataBaseManager.Instance.seasonSet.ToList())
                      {
                          seasons.Add(i);
                      }
                      Owner.MainDataGrid.ItemsSource = seasons;
                  }));
            }
        }

        private ObservableCollection<Referee> referees;
        private RelayCommand refereesDataGridCommand;
        public RelayCommand RefereesDataGridCommand
        {
            get
            {
                return refereesDataGridCommand ??
                  (refereesDataGridCommand = new RelayCommand(obj =>
                  {
                      referees = new ObservableCollection<Referee>();
                      foreach (var i in DataBaseManager.Instance.refereeSet.ToList())
                      {
                          referees.Add(i);
                      }
                      Owner.MainDataGrid.ItemsSource = referees;
                  }));
            }
        }

        private ObservableCollection<Coach> coaches;
        private RelayCommand coachesDataGridCommand;
        public RelayCommand CoachesDataGridCommand
        {
            get
            {
                return coachesDataGridCommand ??
                  (coachesDataGridCommand = new RelayCommand(obj =>
                  {
                      coaches = new ObservableCollection<Coach>();
                      foreach (var i in DataBaseManager.Instance.coachSet.ToList())
                      {
                          coaches.Add(i);
                      }
                      Owner.MainDataGrid.ItemsSource = coaches;
                  }));
            }
        }

        private ObservableCollection<Player> players;
        private RelayCommand playersDataGridCommand;
        public RelayCommand PlayersDataGridCommand
        {
            get
            {
                return playersDataGridCommand ??
                  (playersDataGridCommand = new RelayCommand(obj =>
                  {
                      players = new ObservableCollection<Player>();
                      foreach (var i in DataBaseManager.Instance.playerSet.ToList())
                      {
                          players.Add(i);
                      }
                      Owner.MainDataGrid.ItemsSource = players;
                  }));
            }
        }

    }
}
