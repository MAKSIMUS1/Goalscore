using FootballDataApi.Models;
using Goalscore.Commands;
using Goalscore.CustomUI;
using Goalscore.DataBase;
using Goalscore.Model;
using Goalscore.Views;
using Goalscore.Views.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Goalscore.ViewModels
{
    public class FinishedMatchContentSquadViewModel : FrameViewModel<FinishedMatchContentSquad, FinishedMatchWindow>
    {
        private List<Player> homeTeamStartPlayers;
        public List<Player> HomeTeamStartPlayers
        {
            get => homeTeamStartPlayers;
        }
        private List<Player> awayTeamStartPlayers;
        public List<Player> AwayTeamStartPlayers
        {
            get => awayTeamStartPlayers;
        }
        private List<Player> homeTeamBenchPlayers;
        public List<Player> HomeTeamBenchPlayers
        {
            get => homeTeamBenchPlayers;
        }
        private List<Player> awayTeamBenchPlayers;
        public List<Player> AwayTeamBenchPlayers
        {
            get => awayTeamBenchPlayers;
        }


        private List<Player> homeTeamPlayers;
        private List<Player> awayTeamPlayers;
        public FinishedMatchContentSquadViewModel(FinishedMatchContentSquad owner, FinishedMatchWindow window, MatchFinished matchFinished) : base(owner, window)
        {
            homeTeamPlayers = new List<Player>();
            awayTeamPlayers = new List<Player>();

            homeTeamStartPlayers = new List<Player>();
            awayTeamStartPlayers = new List<Player>();
            homeTeamBenchPlayers = new List<Player>();
            awayTeamBenchPlayers = new List<Player>();
            MatchTeam HomeMatchTeam = DataBase.DataBaseManager.Instance.matchTeamSet.ToList().Where(mt => mt.Id == matchFinished.HomeTeamId).Single();
            MatchTeam AwayMatchTeam = DataBase.DataBaseManager.Instance.matchTeamSet.ToList().Where(mt => mt.Id == matchFinished.AwayTeamId).Single();
            List<Player> players = DataBaseManager.Instance.playerSet.ToList();

            foreach (Player p in players)
            {
                if (p.TeamId != null)
                {
                    if (p.TeamId == matchFinished.HomeTeam.Id)
                    {
                        homeTeamPlayers.Add(p);
                    }
                    if (p.TeamId == matchFinished.AwayTeam.Id)
                    {
                        awayTeamPlayers.Add(p);
                    }
                }
            }

            foreach (Player p in homeTeamPlayers)
                if (p.Id == HomeMatchTeam.GKId ||
                    p.Id == HomeMatchTeam.LBId ||
                    p.Id == HomeMatchTeam.CB1Id ||
                    p.Id == HomeMatchTeam.CB2Id ||
                    p.Id == HomeMatchTeam.RBId ||
                    p.Id == HomeMatchTeam.LCMId ||
                    p.Id == HomeMatchTeam.CMId ||
                    p.Id == HomeMatchTeam.RCMId ||
                    p.Id == HomeMatchTeam.LWId ||
                    p.Id == HomeMatchTeam.STId ||
                    p.Id == HomeMatchTeam.RWId)
                    homeTeamStartPlayers.Add(p);
            foreach (Player p in awayTeamPlayers)
                if (p.Id == AwayMatchTeam.GKId ||
                    p.Id == AwayMatchTeam.LBId ||
                    p.Id == AwayMatchTeam.CB1Id ||
                    p.Id == AwayMatchTeam.CB2Id ||
                    p.Id == AwayMatchTeam.RBId ||
                    p.Id == AwayMatchTeam.LCMId ||
                    p.Id == AwayMatchTeam.CMId ||
                    p.Id == AwayMatchTeam.RCMId ||
                    p.Id == AwayMatchTeam.LWId ||
                    p.Id == AwayMatchTeam.STId ||
                    p.Id == AwayMatchTeam.RWId)
                    awayTeamStartPlayers.Add(p);
            IEnumerable<Player> hometp = homeTeamPlayers.Where(p => !homeTeamStartPlayers.Select(spl => spl.Id).ToList().Contains(p.Id));
            IEnumerable<Player> awaytp = awayTeamPlayers.Where(p => !awayTeamStartPlayers.Select(spl => spl.Id).ToList().Contains(p.Id));
            foreach(Player p in hometp)
                homeTeamBenchPlayers.Add(p);
            foreach (Player p in awaytp)
                awayTeamBenchPlayers.Add(p);
        }

        #region SelectedItemListViews

        private Player homeStartSelectedPlayer;
        public Player HomeStartSelectedPlayer
        {
            get { return homeStartSelectedPlayer; }
            set
            {
                homeStartSelectedPlayer = value;
                OnPropertyChanged("HomeStartSelectedPlayer");
            }
        }
        private Player awayStartSelectedPlayer;
        public Player AwayStartSelectedPlayer
        {
            get { return awayStartSelectedPlayer; }
            set
            {
                awayStartSelectedPlayer = value;
                OnPropertyChanged("AwayStartSelectedPlayer");
            }
        }
        private Player homeBenchSelectedPlayer;
        public Player HomeBenchSelectedPlayer
        {
            get { return homeBenchSelectedPlayer; }
            set
            {
                homeBenchSelectedPlayer = value;
                OnPropertyChanged("HomeBenchSelectedPlayer");
            }
        }
        private Player awayBenchSelectedPlayer;
        public Player AwayBenchSelectedPlayer
        {
            get { return awayBenchSelectedPlayer; }
            set
            {
                awayBenchSelectedPlayer = value;
                OnPropertyChanged("AwayBenchSelectedPlayer");
            }
        }

        #endregion
    }
}