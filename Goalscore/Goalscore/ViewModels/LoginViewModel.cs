using Goalscore.Commands;
using Goalscore.Model;
using Goalscore.Utilities;
using Goalscore.Views;
using Goalscore.Views.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Goalscore.ViewModels
{
    public class LoginViewModel : FrameViewModel<Login, AuthorizationWindow>
    {
        public LoginViewModel(Login owner, AuthorizationWindow window) : base(owner, window)
        {
        }
        private RelayCommand toRegistrationCommand;
        public RelayCommand ToRegistrationCommand
        {
            get
            {
                return toRegistrationCommand ??
                  (toRegistrationCommand = new RelayCommand(obj =>
                  {
                      OwnerWindow.AuthorizationFrame.Content = new Registration(OwnerWindow);
                  }));
            }
        }

        private RelayCommand loginCommand;
        public RelayCommand LoginCommand
        {
            get
            {
                return loginCommand ??
                  (loginCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (DataBase.DataBaseManager.Instance.userSet.Find(Owner.LoginTextBox.Text) != null)
                          {
                              User user = DataBase.DataBaseManager.Instance.userSet.ToList().Where(u => u.NickName.Equals(Owner.LoginTextBox.Text)).Single();
                              if (!PasswordHasher.Compare(user.Password, Owner.PasswordTextBox.Text))
                                  throw new Exception("User not exists, or incorrect password");
                              User.current = user;
                              MainWindow window = new MainWindow();
                              window.Show();
                              OwnerWindow.Close();
                          }
                          else
                          {
                              throw new Exception("User not exists, or incorrect password");
                          }
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                      }
                  }));
            }
        }
    }
}