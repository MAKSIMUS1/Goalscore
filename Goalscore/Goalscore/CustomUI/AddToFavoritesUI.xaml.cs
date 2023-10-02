using Goalscore.Commands;
using Goalscore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Goalscore.CustomUI
{
    /// <summary>
    /// Логика взаимодействия для AddToFavoritesUI.xaml
    /// </summary>
    public partial class AddToFavoritesUI : UserControl, INotifyPropertyChanged
    {
        public AddToFavoritesUI()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty ImageSourceProperty;
        public static readonly DependencyProperty CornerRadiusProperty;
        public static readonly DependencyProperty ColorProperty;
        public static readonly DependencyProperty SelectedColorProperty;
        public static readonly DependencyProperty BorderColorProperty;
        public static readonly DependencyProperty BorderSizeProperty;
        public static readonly DependencyProperty IsSelectedProperty;
        public static readonly DependencyProperty IdProperty;

        public static readonly DependencyProperty ClickCommandProperty;

        #region props

        public string ImageSource
        {
            get => (string)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        public int CornerRadius
        {
            get => (int)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        public int BorderSize
        {
            get => (int)GetValue(BorderSizeProperty);
            set => SetValue(BorderSizeProperty, value);
        }
        public int? Id
        {
            get => (int)GetValue(IdProperty);
            set => SetValue(IdProperty, value);
        }

        public bool IsSelected
        {
            get => (bool)GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }

        public Brush Color
        {
            get => GetValue(ColorProperty) as Brush;
            set => SetValue(ColorProperty, value);
        }
        public Brush SelectedColor
        {
            get => GetValue(SelectedColorProperty) as Brush;
            set => SetValue(SelectedColorProperty, value);
        }
        public Brush BorderColor
        {
            get => GetValue(BorderColorProperty) as Brush;
            set => SetValue(BorderColorProperty, value);
        }

        public ICommand ClickCommand
        {
            get => GetValue(ClickCommandProperty) as ICommand;
            set => SetValue(ClickCommandProperty, value);
        }

        #endregion

        static AddToFavoritesUI()
        {
            ImageSourceProperty = DependencyProperty.Register(
            "ImageSource", typeof(string), typeof(AddToFavoritesUI)
            );

            CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius", typeof(int), typeof(AddToFavoritesUI)
            );

            BorderSizeProperty = DependencyProperty.Register(
            "BorderSize", typeof(int), typeof(AddToFavoritesUI)
            );

            ColorProperty = DependencyProperty.Register(
            "Color", typeof(Brush), typeof(AddToFavoritesUI)
            );

            IdProperty = DependencyProperty.Register(
            "Id", typeof(int), typeof(AddToFavoritesUI), new PropertyMetadata(0)
            );

            SelectedColorProperty = DependencyProperty.Register(
            "SelectedColor", typeof(Brush), typeof(AddToFavoritesUI)
            );

            BorderColorProperty = DependencyProperty.Register(
            "BorderColor", typeof(Brush), typeof(AddToFavoritesUI)
            );

            ClickCommandProperty = DependencyProperty.Register(
            "ClickCommand", typeof(ICommand), typeof(AddToFavoritesUI)
            );

            IsSelectedProperty = DependencyProperty.Register(
            "IsSelected", typeof(bool), typeof(AddToFavoritesUI)
            );
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(IsSelected)
            {
                DataBase.DataBaseManager.Instance.userFavoritePlayersSet.Remove(
                    DataBase.DataBaseManager.Instance.userFavoritePlayersSet.ToList().
                    Where(u => u.UserNickName.Equals(User.current.NickName) && u.PlayerId == Id).Single());
                DataBase.DataBaseManager.Instance.SaveChanges();
            }
            else
            {
                UserFavoritePlayers userFavoritePlayers = new UserFavoritePlayers();
                userFavoritePlayers.UserNickName = User.current.NickName;
                userFavoritePlayers.Player = DataBase.DataBaseManager.Instance.playerSet.Where(p => p.Id == Id).Single();
                DataBase.DataBaseManager.Instance.userFavoritePlayersSet.Add(userFavoritePlayers);
                DataBase.DataBaseManager.Instance.SaveChanges();
            }

            IsSelected = !IsSelected;
            if (IsSelected)
                ImageSource = "../Resources/Icons/YellowStar.png";
            else
                ImageSource = "../Resources/Icons/Star.png";
        }

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                ((INotifyPropertyChanged)control).PropertyChanged += value;
            }

            remove
            {
                ((INotifyPropertyChanged)control).PropertyChanged -= value;
            }
        }

        private void control_Loaded(object sender, RoutedEventArgs e)
        {
            IEnumerable<UserFavoritePlayers> userFavorite = DataBase.DataBaseManager.Instance.userFavoritePlayersSet.ToList().Where(u => u.UserNickName.Equals(User.current.NickName));
            foreach(UserFavoritePlayers userFavoritePlayer in userFavorite) 
            { 
                if(userFavoritePlayer.PlayerId == Id)
                {
                    IsSelected = true;
                    break;
                }
            }
            if (IsSelected)
                ImageSource = "../Resources/Icons/YellowStar.png";
            else
                ImageSource = "../Resources/Icons/Star.png";
        }
    }
}