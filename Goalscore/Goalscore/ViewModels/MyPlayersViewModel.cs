using FootballDataApi.Models;
using Goalscore.Model;
using Goalscore.Views.Frames;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goalscore.ViewModels
{
    public class MyPlayersViewModel : FrameViewModel<MyPlayersFrame, MainWindow>
    {
        protected internal ObservableCollection<Player> Players = new ObservableCollection<Player>();
        public MyPlayersViewModel(MyPlayersFrame owner, MainWindow window) : base(owner, window)
        {
            IEnumerable<UserFavoritePlayers> userFav = DataBase.DataBaseManager.Instance.userFavoritePlayersSet.ToList().Where(u => u.UserNickName.Equals(User.current.NickName));
            foreach(UserFavoritePlayers usF in userFav)
            {
                Players.Add(DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == usF.PlayerId).Single());
            }
            Owner.PlayersDataGrid.ItemsSource = Players;
        }
    }
}
