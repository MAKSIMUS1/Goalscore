using Goalscore.Views.Frames;
using Goalscore.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goalscore.Commands;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;
using Goalscore.Model;

namespace Goalscore.ViewModels
{
    public class ProfileViewModel : FrameViewModel<ProfileFrame, MainWindow>
    {
        public ProfileViewModel(ProfileFrame owner, MainWindow window) : base(owner, window)
        {
            Owner.NickNameTextBlock.Text = User.current.NickName;
            if (User.current.ProfileIamge == null)
            {
                Uri uriImageSource = new Uri(@"/Goalscore;component/Resources/user.png", UriKind.RelativeOrAbsolute);
                Owner.ProfileImage.Source = new BitmapImage(uriImageSource);
            }
            else
            {
                Owner.ProfileImage.Source = BitmapFrame.Create(new Uri(User.current.ProfileIamge));
            }
        }
        
        private RelayCommand setProfileImageCommand;
        public RelayCommand SetProfileImageCommand
        {
            get
            {
                return setProfileImageCommand ??
                  (setProfileImageCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          Microsoft.Win32.OpenFileDialog open = new Microsoft.Win32.OpenFileDialog();
                          bool? response = open.ShowDialog();
                          if (response.HasValue)
                          {
                              if (response.Value == true)
                              {
                                  string image = open.FileName;
                                  User.current.ProfileIamge = image;
                                  DataBase.DataBaseManager.Instance.SaveChanges();
                                  Owner.ProfileImage.Source = BitmapFrame.Create(new Uri(User.current.ProfileIamge));

                              }
                          }
                      }
                      catch(Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                      }
                  }));
            }
        }
    }
}
