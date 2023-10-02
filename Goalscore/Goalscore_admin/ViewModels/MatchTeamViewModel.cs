using FootballDataApi.Models;
using Goalscore.Commands;
using Goalscore.DataBase;
using Goalscore.ViewModels;
using Goalscore_admin.Views.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Goalscore_admin.ViewModels
{
    public class MatchTeamViewModel : FrameViewModel<MatchTeamFrame, MainWindow>
    {
        public MatchTeamViewModel(MatchTeamFrame owner, MainWindow window) : base(owner, window)
        {

        }
        private RelayCommand teamIdChangedCommand;
        public RelayCommand TeamIdChangedCommand
        {
            get
            {
                return teamIdChangedCommand ??
                  (teamIdChangedCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (!string.IsNullOrEmpty(Owner.TeamIdTextBox.Text))
                          {
                              if (DataBaseManager.Instance.teamSet.Find(Convert.ToInt32(Owner.TeamIdTextBox.Text)) != null)
                              {
                                  int teamid = Convert.ToInt32(Owner.TeamIdTextBox.Text);
                                  var players = DataBaseManager.Instance.playerSet.ToList();
                                  List<string> ALLpl = new List<string>();
                                  foreach (var p in players)
                                  {
                                      if (p.TeamId != null)
                                      {
                                          if (p.TeamId == teamid)
                                          {
                                              ALLpl.Add(p.Name);
                                          }
                                      }
                                  }
                                  Owner.CaptainComboBox.ItemsSource = ALLpl;
                                  Owner.GKComboBox.ItemsSource = ALLpl;
                                  Owner.LBComboBox.ItemsSource = ALLpl;
                                  Owner.CB1ComboBox.ItemsSource = ALLpl;
                                  Owner.CB2ComboBox.ItemsSource = ALLpl;
                                  Owner.RBComboBox.ItemsSource = ALLpl;
                                  Owner.LCMComboBox.ItemsSource = ALLpl;
                                  Owner.CMComboBox.ItemsSource = ALLpl;
                                  Owner.RCMComboBox.ItemsSource = ALLpl;
                                  Owner.LWComboBox.ItemsSource = ALLpl;
                                  Owner.STComboBox.ItemsSource = ALLpl;
                                  Owner.RWComboBox.ItemsSource = ALLpl;
                              }
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }

        private RelayCommand addMatchTeam;
        public RelayCommand AddMatchTeam
        {
            get
            {
                return addMatchTeam ??
                  (addMatchTeam = new RelayCommand(obj =>
                  {
                      try
                      {
                          MatchTeam matchTeam = new MatchTeam();
                          matchTeam.Team = DataBaseManager.Instance.teamSet.ToList().Where(t => t.Id == Convert.ToInt32(Owner.TeamIdTextBox.Text)).Single();
                          matchTeam.Coach = DataBaseManager.Instance.coachSet.ToList().Where(c => c.Id == Convert.ToInt32(Owner.CoachIdTextBox.Text)).Single();

                          if (!string.IsNullOrEmpty(Owner.TeamIdTextBox.Text))
                          {
                              int teamId = Convert.ToInt32(Owner.TeamIdTextBox.Text);
                              var players = DataBaseManager.Instance.playerSet.ToList();

                              foreach (var p in players)
                              {
                                  if (p.TeamId != null && !string.IsNullOrEmpty(p.Name))
                                  {
                                      if (p.TeamId == teamId)
                                      {
                                          if(p.Name.Equals(Owner.CaptainComboBox.Text))
                                          {
                                              matchTeam.Captain = p;
                                          }
                                          if(p.Name.Equals(Owner.GKComboBox.Text))
                                          {
                                              matchTeam.GK = p;
                                          }
                                          if (p.Name.Equals(Owner.LBComboBox.Text))
                                          {
                                              matchTeam.LB = p;
                                          }
                                          if (p.Name.Equals(Owner.CB1ComboBox.Text))
                                          {
                                              matchTeam.CB1 = p;
                                          }
                                          if (p.Name.Equals(Owner.CB2ComboBox.Text))
                                          {
                                              matchTeam.CB2 = p;
                                          }
                                          if (p.Name.Equals(Owner.RBComboBox.Text))
                                          {
                                              matchTeam.RB = p;
                                          }
                                          if (p.Name.Equals(Owner.LCMComboBox.Text))
                                          {
                                              matchTeam.LCM = p;
                                          }
                                          if (p.Name.Equals(Owner.CMComboBox.Text))
                                          {
                                              matchTeam.CM = p;
                                          }
                                          if (p.Name.Equals(Owner.RCMComboBox.Text))
                                          {
                                              matchTeam.RCM = p;
                                          }
                                          if (p.Name.Equals(Owner.LWComboBox.Text))
                                          {
                                              matchTeam.LW = p;
                                          }
                                          if (p.Name.Equals(Owner.STComboBox.Text))
                                          {
                                              matchTeam.ST = p;
                                          }
                                          if (p.Name.Equals(Owner.RWComboBox.Text))
                                          {
                                              matchTeam.RW = p;
                                          }
                                      }
                                  }
                              }
                          }


                          DataBaseManager.Instance.matchTeamSet.Add(matchTeam);
                          DataBaseManager.Instance.SaveChanges();
                      }
                      catch(Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
    }
}
