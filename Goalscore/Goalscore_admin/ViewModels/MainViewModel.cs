using FootballDataApi;
using FootballDataApi.Models;
using Goalscore.Commands;
using Goalscore.ViewModels;
using Goalscore.Views;
using Goalscore_admin.Views.Frames;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows;

namespace Goalscore_admin.ViewModels
{
    public class MainViewModel : WindowViewModel<MainWindow>
    {
        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(async obj =>
                  {

                      Goalscore.DataBase.DataBaseManager.Instance.Database.Delete();
                      Goalscore.DataBase.DataBaseManager.Instance.Database.Initialize(false);

                      var httpClient = new HttpClient();
                      httpClient.DefaultRequestHeaders.Add("X-Auth-Token", "4fa92be2a5984657b173cbb26cddec96");

                      //<---------- Areas ---------->
                      var areaController = AreaProvider.Create().With(httpClient).Build();
                      var areas = await areaController.GetAllAreas();
                      Goalscore.DataBase.DataBaseManager.Instance.areaSet.AddRange(areas);
                      Goalscore.DataBase.DataBaseManager.Instance.SaveChanges();
                      //<---------- Areas END ---------->

                      //<---------- Competition ---------->
                      var competitionController = CompetitionProvider.Create().With(httpClient).Build();
                      var competitions = await competitionController.GetAvailableCompetition();
                      foreach (var competition in competitions)
                      {
                          var ar = Goalscore.DataBase.DataBaseManager.Instance.areaSet.ToArray().Where(p => p.Id == competition.Area.Id).Single();
                          competition.Area = ar;
                          Goalscore.DataBase.DataBaseManager.Instance.competitionSet.Add(competition);
                      }
                      Goalscore.DataBase.DataBaseManager.Instance.SaveChanges();
                      //<---------- Competition END ---------->


                      List<Competition> competitions2 = Goalscore.DataBase.DataBaseManager.Instance.competitionSet.ToList();
                      var teamController = TeamProvider.Create().With(httpClient).Build();
                      List<Team> teams = new List<Team>();
                      foreach (Competition competition in competitions2)
                      {
                          IEnumerable<Team> team = await teamController.GetTeamByCompetition(competition.Id);
                          IEnumerable<int?> f = teams.Select(t => t.Id);
                          foreach (Team t in team)
                          {
                              if (!f.Contains(t.Id))
                              {
                                  teams.Add(t);
                              }
                          }
                          MessageBox.Show("From competition \"" + competition.Name + "\" access");
                          Thread.Sleep(5000);
                      }
                      foreach (Team t in teams)
                      {
                          Area area = Goalscore.DataBase.DataBaseManager.Instance.areaSet.ToArray().Where(p => p.Id == t.Area.Id).Single();
                          t.Area = area;
                      }
                      //<---------- PLAYERS ---------->
                      List<Player> players = new List<Player>();
                      List<int?> playersId = new List<int?>();
                      foreach (Team t in teams)
                      {
                          IEnumerable<int?> i = players.Select(s => s.Id);
                          playersId.AddRange(i);
                          foreach (Player pl in t.Squad)
                          {
                              if (!playersId.Contains(pl.Id))
                              {
                                  pl.Team = t;
                                  players.Add(pl);
                              }
                          }
                      }
                      //<---------- PLAYERS END------->
                      Goalscore.DataBase.DataBaseManager.Instance.playerSet.AddRange(players);
                      Goalscore.DataBase.DataBaseManager.Instance.teamSet.AddRange(teams);
                      Goalscore.DataBase.DataBaseManager.Instance.SaveChanges();
                      players.Clear(); teams.Clear();

                      ////<---------- Match ---------->

                      Match match = new Match();
                      match.Id = 160273;
                      match.Competition = Goalscore.DataBase.DataBaseManager.Instance.competitionSet.ToArray().Where(p => p.Id == 2019).Single();
                      match.Season = Goalscore.DataBase.DataBaseManager.Instance.seasonSet.ToArray().Where(p => p.Id == 1490).Single();
                      match.UtcDate = Convert.ToDateTime("2023-06-13 18:00");
                      match.Status = "TIMED";
                      match.Attendance = 22000;
                      match.Matchday = 28;
                      match.Stage = "REGULAR_SEASON";
                      match.Group = null;
                      match.LastUpdated = DateTime.Now;
                      match.HomeTeam = new MatchTeam();
                      match.HomeTeam.Id = 1;
                      match.HomeTeam.Team = Goalscore.DataBase.DataBaseManager.Instance.teamSet.ToArray().Where(p => p.Id == 98).Single();
                      match.AwayTeam = new MatchTeam();
                      match.AwayTeam.Id = 2;
                      match.AwayTeam.Team = Goalscore.DataBase.DataBaseManager.Instance.teamSet.ToArray().Where(p => p.Id == 100).Single();

                      Score score = new Score();
                      score.HalfTime = new GoalScore();
                      score.HalfTime.HomeTeamScore = 1;
                      score.HalfTime.AwayTeamScore = 0;
                      score.FullTime = new GoalScore();
                      score.FullTime.HomeTeamScore = 0;
                      score.FullTime.AwayTeamScore = 0;
                      match.Score = score;

                      match.Referee = new Referee();
                      match.Referee.Id = 24;
                      match.Referee.Name = "Aleks Kokos";
                      match.Referee.Nationality = "Argentina";

                      Goalscore.DataBase.DataBaseManager.Instance.matchSet.AddOrUpdate(match);
                      Goalscore.DataBase.DataBaseManager.Instance.SaveChanges();
                      //<---------- Match END ---------->
                  }));
            }
        }

        //<!---- FRAMES ---->
        FinishedMatchFrame fmf;
        TimedMatchFrame tmf;
        MatchTeamFrame mtf;
        MatchTeamsDataGrid mtdgf;

        public MainViewModel(MainWindow owner) : base(owner)
        {

            fmf = new FinishedMatchFrame(Owner);
            tmf = new TimedMatchFrame(Owner);
            mtf = new MatchTeamFrame(Owner);
            mtdgf = new MatchTeamsDataGrid(Owner);
        }
        private RelayCommand setFinishedMatchFrameCommand;
        public RelayCommand SetFinishedMatchesCommand
        {
            get
            {
                return setFinishedMatchFrameCommand ??
                  (setFinishedMatchFrameCommand = new RelayCommand(obj =>
                  {
                      Owner.MainFrame.Content = fmf;
                  }));
            }
        }
        private RelayCommand setTimedMatchFrameCommand;
        public RelayCommand SetTimedMatchFrameCommand
        {
            get
            {
                return setTimedMatchFrameCommand ??
                  (setTimedMatchFrameCommand = new RelayCommand(obj =>
                  {
                      Owner.MainFrame.Content = tmf;
                  }));
            }
        }
        private RelayCommand setMatchTeamCommand;
        public RelayCommand SetMatchTeamCommand
        {
            get
            {
                return setMatchTeamCommand ??
                  (setMatchTeamCommand = new RelayCommand(obj =>
                  {
                      Owner.MainFrame.Content = mtf;
                  }));
            }
        }
        //------------------------------ Data Grids Frames

        private RelayCommand setMatchTeamsDataGridCommand;
        public RelayCommand SetMatchTeamsDataGridCommand
        {
            get
            {
                return setMatchTeamsDataGridCommand ??
                  (setMatchTeamsDataGridCommand = new RelayCommand(obj =>
                  {
                      Owner.MainFrame.Content = mtdgf;
                  }));
            }
        }
    }
}
