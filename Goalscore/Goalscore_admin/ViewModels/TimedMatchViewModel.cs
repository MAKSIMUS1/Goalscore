using FootballDataApi.Models;
using Goalscore.Commands;
using Goalscore.ViewModels;
using Goalscore_admin.Views.Frames;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Goalscore_admin.ViewModels
{
    public class TimedMatchViewModel : FrameViewModel<TimedMatchFrame, MainWindow>
    {
        public TimedMatchViewModel(TimedMatchFrame owner, MainWindow window) : base(owner, window)
        {

        }
        private RelayCommand addTimedMatch;
        public RelayCommand AddTimedMatch
        {
            get
            {
                return addTimedMatch ??
                  (addTimedMatch = new RelayCommand(obj =>
                  {
                      try
                      {
                          Match match = new Match();
                          match.Id = Convert.ToInt32(Owner.MatchIdTextBox.Text);
                          match.Competition = Goalscore.DataBase.DataBaseManager.Instance.competitionSet.ToArray().Where(p => p.Name.Equals(Owner.CompetitionComboBox.Text)).Single();
                          match.Season = Goalscore.DataBase.DataBaseManager.Instance.seasonSet.ToArray().Where(p => p.Id == match.Competition.SeasonId).Single();
                          match.UtcDate = Convert.ToDateTime(Owner.UtcDateMatchTextBox.Text);
                          match.Status = "FINISHED";
                          match.Matchday = match.Season.CurrentMatchday;
                          match.Stage = Owner.StageComboBox.Text;
                          if (Owner.StageComboBox.Text.Equals("GROUP_STAGE"))
                              match.Group = Owner.GroupStageTextBox.Text;
                          match.LastUpdated = DateTime.Now;
                          match.HomeTeam = Goalscore.DataBase.DataBaseManager.Instance.matchTeamSet.ToArray().Where(p => p.Id == Convert.ToInt32(Owner.HomeTeamIdTextBox.Text)).Single();
                          match.AwayTeam = Goalscore.DataBase.DataBaseManager.Instance.matchTeamSet.ToArray().Where(p => p.Id == Convert.ToInt32(Owner.AwayTeamIdTextBox.Text)).Single();

                          match.Referee = Goalscore.DataBase.DataBaseManager.Instance.refereeSet.ToList().Where(r => r.Name.Equals(Owner.RefereeComboBox.Text)).Single();

                          Goalscore.DataBase.DataBaseManager.Instance.matchSet.AddOrUpdate(match);
                          Goalscore.DataBase.DataBaseManager.Instance.SaveChanges();
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
    }
}
