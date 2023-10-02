using FootballDataApi.Models;
using Goalscore.Commands;
using Goalscore.ViewModels;
using Goalscore_admin.Views.Frames;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Goalscore_admin.ViewModels
{
    public class FinishedMatchViewModel : FrameViewModel<FinishedMatchFrame, MainWindow>
    {
        public FinishedMatchViewModel(FinishedMatchFrame owner, MainWindow window) : base(owner, window)
        {
            try
            {

                IEnumerable<string> competitionNames = Goalscore.DataBase.DataBaseManager.Instance.competitionSet.ToList().Select(c => c.Name);
                foreach (string s in competitionNames)
                    Owner.CompetitionComboBox.Items.Add(s);

                IEnumerable<string> refereeNames = Goalscore.DataBase.DataBaseManager.Instance.refereeSet.ToList().Select(c => c.Name);
                foreach (string s in refereeNames)
                    Owner.RefereeComboBox.Items.Add(s);

                Owner.StageComboBox.Items.Add("REGULAR_SEASON");
                Owner.StageComboBox.Items.Add("GROUP_STAGE");
            }
            catch { }
        }

        private RelayCommand addFinishedMatch;
        public RelayCommand AddFinishedMatch
        {
            get
            {
                return addFinishedMatch ??
                  (addFinishedMatch = new RelayCommand(obj =>
                  {
                      try
                      {
                          Match match = new Match();
                          match.Id = Convert.ToInt32(Owner.MatchIdTextBox.Text);
                          match.Competition = Goalscore.DataBase.DataBaseManager.Instance.competitionSet.ToArray().Where(p => p.Name.Equals(Owner.CompetitionComboBox.Text)).Single();
                          match.Season = Goalscore.DataBase.DataBaseManager.Instance.seasonSet.ToArray().Where(p => p.Id == match.Competition.SeasonId).Single();
                          match.UtcDate = Convert.ToDateTime(Owner.UtcDateMatchTextBox.Text);
                          match.Status = "FINISHED";
                          match.Attendance = Convert.ToInt32(Owner.AttandanceTextBox.Text);
                          match.Matchday = match.Season.CurrentMatchday;
                          match.Stage = Owner.StageComboBox.Text;
                          if (Owner.StageComboBox.Text.Equals("GROUP_STAGE"))
                            match.Group = Owner.GroupStageTextBox.Text;
                          match.LastUpdated = DateTime.Now;
                          match.HomeTeam = Goalscore.DataBase.DataBaseManager.Instance.matchTeamSet.ToArray().Where(p => p.Id == Convert.ToInt32(Owner.HomeTeamIdTextBox.Text)).Single();
                          match.AwayTeam = Goalscore.DataBase.DataBaseManager.Instance.matchTeamSet.ToArray().Where(p => p.Id == Convert.ToInt32(Owner.AwayTeamIdTextBox.Text)).Single();
                          if (!CheckScore())
                              throw new Exception("Error: Score not correct");
                          Score score = new Score();
                          score.HalfTime = new GoalScore();
                          score.HalfTime.HomeTeamScore = Convert.ToInt32(Owner.HalfTimeHomeTeamScore.Text);
                          score.HalfTime.AwayTeamScore = Convert.ToInt32(Owner.HalfTimeAwayTeamScore.Text);
                          score.FullTime = new GoalScore();
                          score.FullTime.HomeTeamScore = Convert.ToInt32(Owner.FullTimeHomeTeamScore.Text);
                          score.FullTime.AwayTeamScore = Convert.ToInt32(Owner.FullTimeAwayTeamScore.Text);
                          score.ExtraTime = new GoalScore();
                          score.ExtraTime.HomeTeamScore = -1;
                          score.ExtraTime.AwayTeamScore = -1;
                          score.Penalties = new GoalScore();
                          score.Penalties.HomeTeamScore = -1;
                          score.Penalties.AwayTeamScore = -1;
                          match.Score = score;

                          match.Referee = Goalscore.DataBase.DataBaseManager.Instance.refereeSet.ToList().Where(r => r.Name.Equals(Owner.RefereeComboBox.Text )).Single();

                          Goalscore.DataBase.DataBaseManager.Instance.matchSet.AddOrUpdate(match);
                          Goalscore.DataBase.DataBaseManager.Instance.SaveChanges();
                      }
                      catch(Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }

        private bool CheckScore()
        {
            if (Convert.ToInt32(Owner.HalfTimeHomeTeamScore.Text) < 0 ||
                Convert.ToInt32(Owner.HalfTimeAwayTeamScore.Text) < 0 ||
                Convert.ToInt32(Owner.FullTimeHomeTeamScore.Text) < 0 ||
                Convert.ToInt32(Owner.FullTimeAwayTeamScore.Text) < 0)
                return false;
            if ((Convert.ToInt32(Owner.HalfTimeHomeTeamScore.Text) + Convert.ToInt32(Owner.HalfTimeAwayTeamScore.Text)) > 
                (Convert.ToInt32(Owner.FullTimeHomeTeamScore.Text) + Convert.ToInt32(Owner.FullTimeAwayTeamScore.Text)))
                return false;
            if (Convert.ToInt32(Owner.HalfTimeHomeTeamScore.Text) > Convert.ToInt32(Owner.FullTimeHomeTeamScore.Text))
                return false;
            if (Convert.ToInt32(Owner.HalfTimeAwayTeamScore.Text) > Convert.ToInt32(Owner.FullTimeAwayTeamScore.Text))
                return false;
            return true;
        }
    }
}
