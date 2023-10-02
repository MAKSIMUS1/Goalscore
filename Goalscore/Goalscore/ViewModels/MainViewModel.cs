using FootballDataApi;
using FootballDataApi.Models;
using Goalscore.Commands;
using Goalscore.Views;
using Goalscore.Views.Frames;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WPFUIKitProfessional.Themes;

namespace Goalscore.ViewModels
{
    public class MainViewModel : WindowViewModel<MainWindow>
    {
        private readonly MatchesFrame matchesFrame; 
        private readonly ProfileFrame profileFrame;
        public MainViewModel(MainWindow owner) : base(owner)
        {
            matchesFrame = new MatchesFrame(Owner);
            profileFrame = new ProfileFrame(Owner);

            Owner.MainFrame.Content = matchesFrame;
        }

        private RelayCommand themesChangeCommand;
        public RelayCommand ThemesChangeCommand
        {
            get
            {
                return themesChangeCommand ??
                  (themesChangeCommand = new RelayCommand(obj =>
                  {
                      if (Owner.Themes.IsChecked == true)
                          ThemesController.SetTheme(ThemesController.ThemeTypes.Dark);
                      else
                          ThemesController.SetTheme(ThemesController.ThemeTypes.Light);
                  }));
            }
        }

        #region SetPagesCommands

        private RelayCommand homePageCommand;
        public RelayCommand HomePageCommand
        {
            get
            {
                return homePageCommand ??
                  (homePageCommand = new RelayCommand(obj =>
                  {
                      Owner.MainFrame.Content = matchesFrame;
                  }));
            }
        }
        private RelayCommand myPlayersPageCommand;
        public RelayCommand MyPlayersPageCommand
        {
            get
            {
                return myPlayersPageCommand ??
                  (myPlayersPageCommand = new RelayCommand(obj =>
                  {
                      Owner.MainFrame.Content = new MyPlayersFrame(Owner);
                  }));
            }
        }
        
        private RelayCommand userTeamPageCommand;
        public RelayCommand UserTeamPageCommand
        {
            get
            {
                return userTeamPageCommand ??
                  (userTeamPageCommand = new RelayCommand(obj =>
                  {
                      Owner.MainFrame.Content = new UserTeamFrame(Owner);
                  }));
            }
        }
        private RelayCommand profilePageCommand;
        public RelayCommand ProfilePageCommand
        {
            get
            {
                return profilePageCommand ??
                  (profilePageCommand = new RelayCommand(obj =>
                  {
                      Owner.MainFrame.Content = profileFrame;
                  }));
            }
        }

        #endregion

        #region TopPanelButton

        private RelayCommand closeWindowCommand;
        public RelayCommand CloseWindowCommand
        {
            get
            {
                return closeWindowCommand ??
                  (closeWindowCommand = new RelayCommand(obj =>
                  {
                      Owner.Close();
                  }));
            }
        }
        private RelayCommand restoreWindowCommand;
        public RelayCommand RestoreWindowCommand
        {
            get
            {
                return restoreWindowCommand ??
                  (restoreWindowCommand = new RelayCommand(obj =>
                  {
                      if (Owner.WindowState == WindowState.Normal)
                      {
                          Owner.WindowState = WindowState.Maximized;
                          return;
                      }
                      if (Owner.WindowState == WindowState.Maximized)
                      {
                          Owner.WindowState = WindowState.Normal;
                          return;
                      }
                  }));
            }
        }
        private RelayCommand minimizeWindowCommand;
        public RelayCommand MinimizeWindowCommand
        {
            get
            {
                return minimizeWindowCommand ??
                  (minimizeWindowCommand = new RelayCommand(obj =>
                  {
                          Owner.WindowState = WindowState.Minimized;
                  }));
            }
        }
        #endregion
    }
}
