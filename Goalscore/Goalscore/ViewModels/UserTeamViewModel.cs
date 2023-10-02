using FootballDataApi.Models;
using Goalscore.Commands;
using Goalscore.Model;
using Goalscore.Views.Frames;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Goalscore.ViewModels
{
    public class UserTeamViewModel : FrameViewModel<UserTeamFrame, MainWindow>
    {
        protected internal ObservableCollection<Player> Players = new ObservableCollection<Player>();
        private UserTeam userTeam;
        public UserTeamViewModel(UserTeamFrame owner, MainWindow window) : base(owner, window)
        {
            IEnumerable<UserFavoritePlayers> userFav = DataBase.DataBaseManager.Instance.userFavoritePlayersSet.ToList().Where(u => u.UserNickName.Equals(User.current.NickName));
            foreach (UserFavoritePlayers usF in userFav)
            {
                Players.Add(DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == usF.PlayerId).Single());
            }
            Owner.PlayersDataGrid.ItemsSource = Players;

            if (DataBase.DataBaseManager.Instance.userTeamSet.ToList().Any(t => t.UserNickName.Equals(User.current.NickName)))
            {
                userTeam = DataBase.DataBaseManager.Instance.userTeamSet.ToList().Where(t => t.UserNickName.Equals(User.current.NickName)).Single();

                //GK
                if (userTeam.GKId != null)
                {
                    Owner.GK.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.GKId);
                    Owner.GK.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.GKId).Single().Name;
                }
                else
                {
                    Owner.GK.ImageSource = "../../Resources/add_player.png";
                    Owner.GK.Text = "No player";
                }
                //LB
                if (userTeam.LBId != null)
                {
                    Owner.LB.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.LBId);
                    Owner.LB.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.LBId).Single().Name;
                }
                else
                {
                    Owner.LB.ImageSource = "../../Resources/add_player.png";
                    Owner.LB.Text = "No player";
                }
                //CB1
                if (userTeam.CB1Id != null)
                {
                    Owner.CB1.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.CB1Id);
                    Owner.CB1.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.CB1Id).Single().Name;
                }
                else
                {
                    Owner.CB1.ImageSource = "../../Resources/add_player.png";
                    Owner.CB1.Text = "No player";
                }
                //CB2
                if (userTeam.CB2Id != null)
                {
                    Owner.CB2.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.CB2Id);
                    Owner.CB2.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.CB2Id).Single().Name;
                }
                else
                {
                    Owner.CB2.ImageSource = "../../Resources/add_player.png";
                    Owner.CB2.Text = "No player";
                }
                //RB
                if (userTeam.RBId != null)
                {
                    Owner.RB.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.RBId);
                    Owner.RB.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.RBId).Single().Name;
                }
                else
                {
                    Owner.RB.ImageSource = "../../Resources/add_player.png";
                    Owner.RB.Text = "No player";
                }
                //LCM
                if (userTeam.LCMId != null)
                {
                    Owner.LCM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.LCMId);
                    Owner.LCM.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.LCMId).Single().Name;
                }
                else
                {
                    Owner.LCM.ImageSource = "../../Resources/add_player.png";
                    Owner.LCM.Text = "No player";
                }
                //CM
                if (userTeam.CMId != null)
                {
                    Owner.CM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.CMId);
                    Owner.CM.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.CMId).Single().Name;
                }
                else
                {
                    Owner.CM.ImageSource = "../../Resources/add_player.png";
                    Owner.CM.Text = "No player";
                }
                //RCM
                if (userTeam.RCMId != null)
                {
                    Owner.RCM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.RCMId);
                    Owner.RCM.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.RCMId).Single().Name;
                }
                else
                {
                    Owner.RCM.ImageSource = "../../Resources/add_player.png";
                    Owner.RCM.Text = "No player";
                }
                //LW
                if (userTeam.LWId != null)
                {
                    Owner.LW.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.LWId);
                    Owner.LW.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.LWId).Single().Name;
                }
                else
                {
                    Owner.LW.ImageSource = "../../Resources/add_player.png";
                    Owner.LW.Text = "No player";
                }
                //ST
                if (userTeam.STId != null)
                {
                    Owner.ST.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.STId);
                    Owner.ST.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.STId).Single().Name;
                }
                else
                {
                    Owner.ST.ImageSource = "../../Resources/add_player.png";
                    Owner.ST.Text = "No player";
                }
                //RW
                if (userTeam.RWId != null)
                {
                    Owner.RW.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.RWId);
                    Owner.RW.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.RWId).Single().Name;
                }
                else
                {
                    Owner.RW.ImageSource = "../../Resources/add_player.png";
                    Owner.RW.Text = "No player";
                }
            }
            else
            {
                userTeam = new UserTeam();
                userTeam.UserNickName = User.current.NickName;
                DataBase.DataBaseManager.Instance.userTeamSet.Add(userTeam);
                DataBase.DataBaseManager.Instance.SaveChanges();
            }
            CalculateTeamPower();
        }
        private RelayCommand setGK;
        public RelayCommand SetGK
        {
            get
            {
                return setGK ??
                  (setGK = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.GKId = player.Id;
                              //--- проверка на уникальный состав
                              if (userTeam.LBId != null)
                                  if (userTeam.LBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB1Id != null)
                                  if (userTeam.CB1Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB2Id != null)
                                  if (userTeam.CB2Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RBId != null)
                                  if (userTeam.RBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LCMId != null)
                                  if (userTeam.LCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CMId != null)
                                  if (userTeam.CMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RCMId != null)
                                  if (userTeam.RCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LWId != null)
                                  if (userTeam.LWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.STId != null)
                                  if (userTeam.STId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RWId != null)
                                  if (userTeam.RWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.GK.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.GKId);
                              Owner.GK.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.GKId).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                      }
                  }));
            }
        }
        private RelayCommand setLB;
        public RelayCommand SetLB
        {
            get
            {
                return setLB ??
                  (setLB = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.LBId = player.Id;

                              //--- проверка на уникальный состав
                              if (userTeam.GKId != null)
                                  if (userTeam.GKId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB1Id != null)
                                  if (userTeam.CB1Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB2Id != null)
                                  if (userTeam.CB2Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RBId != null)
                                  if (userTeam.RBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LCMId != null)
                                  if (userTeam.LCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CMId != null)
                                  if (userTeam.CMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RCMId != null)
                                  if (userTeam.RCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LWId != null)
                                  if (userTeam.LWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.STId != null)
                                  if (userTeam.STId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RWId != null)
                                  if (userTeam.RWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.LB.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.LBId);
                              Owner.LB.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.LBId).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand setCB1;
        public RelayCommand SetCB1
        {
            get
            {
                return setCB1 ??
                  (setCB1 = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.CB1Id = player.Id;
                              //--- проверка на уникальный состав
                              if (userTeam.GKId != null)
                                  if (userTeam.GKId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LBId != null)
                                  if (userTeam.LBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB2Id != null)
                                  if (userTeam.CB2Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RBId != null)
                                  if (userTeam.RBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LCMId != null)
                                  if (userTeam.LCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CMId != null)
                                  if (userTeam.CMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RCMId != null)
                                  if (userTeam.RCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LWId != null)
                                  if (userTeam.LWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.STId != null)
                                  if (userTeam.STId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RWId != null)
                                  if (userTeam.RWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.CB1.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.CB1Id);
                              Owner.CB1.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.CB1Id).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand setCB2;
        public RelayCommand SetCB2
        {
            get
            {
                return setCB2 ??
                  (setCB2 = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.CB2Id = player.Id;
                              //--- проверка на уникальный состав
                              if (userTeam.GKId != null)
                                  if (userTeam.GKId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LBId != null)
                                  if (userTeam.LBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB1Id != null)
                                  if (userTeam.CB1Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RBId != null)
                                  if (userTeam.RBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LCMId != null)
                                  if (userTeam.LCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CMId != null)
                                  if (userTeam.CMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RCMId != null)
                                  if (userTeam.RCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LWId != null)
                                  if (userTeam.LWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.STId != null)
                                  if (userTeam.STId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RWId != null)
                                  if (userTeam.RWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.CB2.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.CB2Id);
                              Owner.CB2.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.CB2Id).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand setRB;
        public RelayCommand SetRB
        {
            get
            {
                return setRB ??
                  (setRB = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.RBId = player.Id;
                              //--- проверка на уникальный состав
                              if (userTeam.GKId != null)
                                  if (userTeam.GKId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LBId != null)
                                  if (userTeam.LBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB1Id != null)
                                  if (userTeam.CB1Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB2Id != null)
                                  if (userTeam.CB2Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LCMId != null)
                                  if (userTeam.LCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CMId != null)
                                  if (userTeam.CMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RCMId != null)
                                  if (userTeam.RCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LWId != null)
                                  if (userTeam.LWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.STId != null)
                                  if (userTeam.STId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RWId != null)
                                  if (userTeam.RWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.RB.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.RBId);
                              Owner.RB.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.RBId).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand setLCM;
        public RelayCommand SetLCM
        {
            get
            {
                return setLCM ??
                  (setLCM = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.LCMId = player.Id;
                              //--- проверка на уникальный состав
                              if (userTeam.GKId != null)
                                  if (userTeam.GKId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LBId != null)
                                  if (userTeam.LBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB1Id != null)
                                  if (userTeam.CB1Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB2Id != null)
                                  if (userTeam.CB2Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RBId != null)
                                  if (userTeam.RBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CMId != null)
                                  if (userTeam.CMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RCMId != null)
                                  if (userTeam.RCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LWId != null)
                                  if (userTeam.LWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.STId != null)
                                  if (userTeam.STId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RWId != null)
                                  if (userTeam.RWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.LCM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.LCMId);
                              Owner.LCM.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.LCMId).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand setCM;
        public RelayCommand SetCM
        {
            get
            {
                return setCM ??
                  (setCM = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.CMId = player.Id;
                              //--- проверка на уникальный состав
                              if (userTeam.GKId != null)
                                  if (userTeam.GKId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LBId != null)
                                  if (userTeam.LBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB1Id != null)
                                  if (userTeam.CB1Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB2Id != null)
                                  if (userTeam.CB2Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RBId != null)
                                  if (userTeam.RBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LCMId != null)
                                  if (userTeam.LCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RCMId != null)
                                  if (userTeam.RCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LWId != null)
                                  if (userTeam.LWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.STId != null)
                                  if (userTeam.STId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RWId != null)
                                  if (userTeam.RWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.CM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.CMId);
                              Owner.CM.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.CMId).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand setRCM;
        public RelayCommand SetRCM
        {
            get
            {
                return setRCM ??
                  (setRCM = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.RCMId = player.Id;
                              //--- проверка на уникальный состав
                              if (userTeam.GKId != null)
                                  if (userTeam.GKId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LBId != null)
                                  if (userTeam.LBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB1Id != null)
                                  if (userTeam.CB1Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB2Id != null)
                                  if (userTeam.CB2Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RBId != null)
                                  if (userTeam.RBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LCMId != null)
                                  if (userTeam.LCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CMId != null)
                                  if (userTeam.CMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LWId != null)
                                  if (userTeam.LWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.STId != null)
                                  if (userTeam.STId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RWId != null)
                                  if (userTeam.RWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.RCM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.RCMId);
                              Owner.RCM.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.RCMId).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand setLW;
        public RelayCommand SetLW
        {
            get
            {
                return setLW ??
                  (setLW = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.LWId = player.Id;
                              //--- проверка на уникальный состав
                              if (userTeam.GKId != null)
                                  if (userTeam.GKId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LBId != null)
                                  if (userTeam.LBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB1Id != null)
                                  if (userTeam.CB1Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB2Id != null)
                                  if (userTeam.CB2Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RBId != null)
                                  if (userTeam.RBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LCMId != null)
                                  if (userTeam.LCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CMId != null)
                                  if (userTeam.CMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RCMId != null)
                                  if (userTeam.RCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.STId != null)
                                  if (userTeam.STId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RWId != null)
                                  if (userTeam.RWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.LW.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.LWId);
                              Owner.LW.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.LWId).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand setST;
        public RelayCommand SetST
        {
            get
            {
                return setST ??
                  (setST = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.STId = player.Id;
                              //--- проверка на уникальный состав
                              if (userTeam.GKId != null)
                                  if (userTeam.GKId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LBId != null)
                                  if (userTeam.LBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB1Id != null)
                                  if (userTeam.CB1Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB2Id != null)
                                  if (userTeam.CB2Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RBId != null)
                                  if (userTeam.RBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LCMId != null)
                                  if (userTeam.LCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CMId != null)
                                  if (userTeam.CMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RCMId != null)
                                  if (userTeam.RCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LWId != null)
                                  if (userTeam.LWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RWId != null)
                                  if (userTeam.RWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.ST.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.STId);
                              Owner.ST.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.STId).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private RelayCommand setRW;
        public RelayCommand SetRW
        {
            get
            {
                return setRW ??
                  (setRW = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (Owner.PlayersDataGrid.SelectedItem != null)
                          {
                              Player player = (Player)Owner.PlayersDataGrid.SelectedItem;
                              userTeam.RWId = player.Id;
                              //--- проверка на уникальный состав
                              if (userTeam.GKId != null)
                                  if (userTeam.GKId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LBId != null)
                                  if (userTeam.LBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB1Id != null)
                                  if (userTeam.CB1Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CB2Id != null)
                                  if (userTeam.CB2Id == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RBId != null)
                                  if (userTeam.RBId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LCMId != null)
                                  if (userTeam.LCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.CMId != null)
                                  if (userTeam.CMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.RCMId != null)
                                  if (userTeam.RCMId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.LWId != null)
                                  if (userTeam.LWId == player.Id)
                                      throw new Exception("This player has already been selected");
                              if (userTeam.STId != null)
                                  if (userTeam.STId == player.Id)
                                      throw new Exception("This player has already been selected");
                              //--- end
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              Owner.RW.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(userTeam.RWId);
                              Owner.RW.Text = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.RWId).Single().Name;
                              CalculateTeamPower();
                          }
                          else
                          {
                              MessageBox.Show("No selected player");
                          }
                      }
                      catch (Exception e)
                      {
                          MessageBox.Show(e.Message);
                      }
                  }));
            }
        }
        private void CalculateTeamPower()
        {
            if (userTeam.GKId == null ||
                userTeam.LBId == null ||
                userTeam.CB1Id == null ||
                userTeam.CB2Id == null ||
                userTeam.RBId == null ||
                userTeam.LCMId == null ||
                userTeam.CMId == null ||
                userTeam.RCMId == null ||
                userTeam.LWId == null ||
                userTeam.STId == null ||
                userTeam.RWId == null)
                return;
            Player GK = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.GKId).Single();
            Player LB = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.LBId).Single();
            Player CB1 = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.CB1Id).Single();
            Player CB2 = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.CB2Id).Single();
            Player RB = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.RBId).Single();
            Player LCM = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.LCMId).Single();
            Player CM = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.CMId).Single();
            Player RCM = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.RCMId).Single();
            Player LW = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.LWId).Single();
            Player ST = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.STId).Single();
            Player RW = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == userTeam.RWId).Single();

            short NationalPower = 0;
            short PlayersInOneTeamPower = 0;
            short PlayersOnPosition = 0;

            if (GK.Nationality.Equals(RB.Nationality)) NationalPower++;
            if (GK.Nationality.Equals(CB1.Nationality)) NationalPower++;
            if (GK.Nationality.Equals(CB2.Nationality)) NationalPower++;
            if (GK.Nationality.Equals(LB.Nationality)) NationalPower++;

            if (LB.Nationality.Equals(LCM.Nationality)) NationalPower++;
            if (LB.Nationality.Equals(CB1.Nationality)) NationalPower++;
            if (CB1.Nationality.Equals(CB2.Nationality)) NationalPower++;
            if (RB.Nationality.Equals(RCM.Nationality)) NationalPower++;
            if (RB.Nationality.Equals(CB2.Nationality)) NationalPower++;

            if (CM.Nationality.Equals(LCM.Nationality)) NationalPower++;
            if (CM.Nationality.Equals(RCM.Nationality)) NationalPower++;
            if (LCM.Nationality.Equals(LW.Nationality)) NationalPower++;
            if (CM.Nationality.Equals(ST.Nationality)) NationalPower++;
            if (RCM.Nationality.Equals(RW.Nationality)) NationalPower++;
            if (LW.Nationality.Equals(ST.Nationality)) NationalPower++;
            if (RW.Nationality.Equals(ST.Nationality)) NationalPower++;


            if (GK.TeamId == RB.TeamId) PlayersInOneTeamPower++;
            if (GK.TeamId == CB1.TeamId) PlayersInOneTeamPower++;
            if (GK.TeamId == CB2.TeamId) PlayersInOneTeamPower++;
            if (GK.TeamId == LB.TeamId) PlayersInOneTeamPower++;

            if (LB.TeamId == LCM.TeamId) PlayersInOneTeamPower++;
            if (LB.TeamId == CB1.TeamId) PlayersInOneTeamPower++;
            if (CB1.TeamId == CB2.TeamId) PlayersInOneTeamPower++;
            if (RB.TeamId == RCM.TeamId) PlayersInOneTeamPower++;
            if (RB.TeamId == CB2.TeamId) PlayersInOneTeamPower++;
                    
            if (CM.TeamId == LCM.TeamId) PlayersInOneTeamPower++;
            if (CM.TeamId == RCM.TeamId) PlayersInOneTeamPower++;
            if (LCM.TeamId == LW.TeamId) PlayersInOneTeamPower++;
            if (CM.TeamId == ST.TeamId) PlayersInOneTeamPower++;
            if (RCM.TeamId == RW.TeamId) PlayersInOneTeamPower++;
            if (LW.TeamId == ST.TeamId) PlayersInOneTeamPower++;
            if (RW.TeamId == ST.TeamId) PlayersInOneTeamPower++;

            if (GK.Position.Equals("Goalkeeper")) PlayersOnPosition++;
            if (LB.Position.Equals("Defence")) PlayersOnPosition++;
            if (CB1.Position.Equals("Defence")) PlayersOnPosition++;
            if (CB2.Position.Equals("Defence")) PlayersOnPosition++;
            if (RB.Position.Equals("Defence")) PlayersOnPosition++;
            if (LCM.Position.Equals("Midfield")) PlayersOnPosition++;
            if (CM.Position.Equals("Midfield")) PlayersOnPosition++;
            if (RCM.Position.Equals("Midfield")) PlayersOnPosition++;
            if (LW.Position.Equals("Offence")) PlayersOnPosition++;
            if (ST.Position.Equals("Offence")) PlayersOnPosition++;
            if (RW.Position.Equals("Offence")) PlayersOnPosition++;

            Owner.TeamPowerTextBlock.FontSize = 28;
            Owner.TeamPowerTextBlock.Text = (NationalPower+ PlayersInOneTeamPower+PlayersOnPosition).ToString();

        }
    }
}