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
    internal class RegistrationViewModel : FrameViewModel<Registration, AuthorizationWindow>
    {
        public RegistrationViewModel(Registration owner, AuthorizationWindow window) : base(owner, window)
        {
        }

        private RelayCommand toLoginCommand;
        public RelayCommand ToLoginCommand
        {
            get
            {
                return toLoginCommand ??
                  (toLoginCommand = new RelayCommand(obj =>
                  {
                      OwnerWindow.AuthorizationFrame.Content = new Login(OwnerWindow);
                  }));
            }
        }
        private RelayCommand registrationCommand;
        public RelayCommand RegistrationCommand
        {
            get
            {
                return registrationCommand ??
                  (registrationCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          User user = new User();
                          user.NickName = Owner.LoginTextBox.Text;
                          if(!Owner.PasswordTextBox.Text.Equals(Owner.PasswordAgainTextBox.Text))
                              throw new Exception("Passwords don't match");
                          user.Password = PasswordHasher.GetHash(Owner.PasswordTextBox.Text);

                          if (DataBase.DataBaseManager.Instance.userSet.Find(user.NickName) == null)
                          {
                              DataBase.DataBaseManager.Instance.userSet.Add(user);
                              DataBase.DataBaseManager.Instance.SaveChanges();
                              User.current = user;
                              MainWindow window = new MainWindow();
                              window.Show();
                              OwnerWindow.Close();
                          }
                          else
                          {
                              throw new Exception("User exists");
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
