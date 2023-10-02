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
    /// Логика взаимодействия для PlayerLineup.xaml
    /// </summary>
    public partial class PlayerLineup : UserControl, INotifyPropertyChanged
    {
        public PlayerLineup()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ImageSourceProperty;
        public static readonly DependencyProperty TextProperty;


        #region props

        public string ImageSource
        {
            get => (string)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        #endregion

        static PlayerLineup()
        {
            ImageSourceProperty = DependencyProperty.Register(
            "ImageSource", typeof(string), typeof(PlayerLineup)
            );
            TextProperty = DependencyProperty.Register(
            "Text", typeof(string), typeof(PlayerLineup)
            );
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
    }
}
