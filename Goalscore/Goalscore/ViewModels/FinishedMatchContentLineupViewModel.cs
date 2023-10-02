using FootballDataApi.Models;
using Goalscore.Model;
using Goalscore.Views;
using Goalscore.Views.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goalscore.ViewModels
{
    public class FinishedMatchContentLineupViewModel : FrameViewModel<FinishedMatchContentLineup, FinishedMatchWindow>
    {
        public FinishedMatchContentLineupViewModel(FinishedMatchContentLineup owner, FinishedMatchWindow window, MatchFinished matchFinished) : base(owner, window)
        {
            MatchTeam homeMatchTeam = DataBase.DataBaseManager.Instance.matchTeamSet.ToList().Where(mt => mt.Id == matchFinished.HomeTeamId).Single();
            MatchTeam awayMatchTeam = DataBase.DataBaseManager.Instance.matchTeamSet.ToList().Where(mt => mt.Id == matchFinished.AwayTeamId).Single();
            Player HomeGK = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.GKId).Single();
            Player HomeLB = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.LBId).Single();
            Player HomeCB1 = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.CB1Id).Single();
            Player HomeCB2 = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.CB2Id).Single();
            Player HomeRB = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.RBId).Single();
            Player HomeLCM = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.LCMId).Single();
            Player HomeCM = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.CMId).Single();
            Player HomeRCM = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.RCMId).Single();
            Player HomeLW = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.LWId).Single();
            Player HomeST = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.STId).Single();
            Player HomeRW = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == homeMatchTeam.RWId).Single();

            Player AwayGK = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.GKId).Single();
            Player AwayLB = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.LBId).Single();
            Player AwayCB1 = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.CB1Id).Single();
            Player AwayCB2 = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.CB2Id).Single();
            Player AwayRB = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.RBId).Single();
            Player AwayLCM = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.LCMId).Single();
            Player AwayCM = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.CMId).Single();
            Player AwayRCM = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.RCMId).Single();
            Player AwayLW = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.LWId).Single();
            Player AwayST = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.STId).Single();
            Player AwayRW = DataBase.DataBaseManager.Instance.playerSet.ToList().Where(p => p.Id == awayMatchTeam.RWId).Single();

            Owner.HomeGK.Text = HomeGK.Name;
            Owner.HomeGK.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeGK.Id);
            Owner.HomeLB.Text = HomeLB.Name;
            Owner.HomeLB.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeLB.Id);
            Owner.HomeCB1.Text = HomeCB1.Name;
            Owner.HomeCB1.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeCB1.Id);
            Owner.HomeCB2.Text = HomeCB2.Name;
            Owner.HomeCB2.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeCB2.Id);
            Owner.HomeRB.Text = HomeRB.Name;
            Owner.HomeRB.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeRB.Id);
            Owner.HomeLCM.Text = HomeLCM.Name;
            Owner.HomeLCM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeLCM.Id);
            Owner.HomeCM.Text = HomeCM.Name;
            Owner.HomeCM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeCM.Id);
            Owner.HomeRCM.Text = HomeRCM.Name;
            Owner.HomeRCM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeRCM.Id);
            Owner.HomeLW.Text = HomeLW.Name;
            Owner.HomeLW.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeLW.Id);
            Owner.HomeST.Text = HomeST.Name;
            Owner.HomeST.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeST.Id);
            Owner.HomeRW.Text = HomeRW.Name;
            Owner.HomeRW.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(HomeRW.Id);

            Owner.AwayGK.Text = AwayGK.Name;
            Owner.AwayGK.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayGK.Id);
            Owner.AwayLB.Text = AwayLB.Name;
            Owner.AwayLB.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayLB.Id);
            Owner.AwayCB1.Text = AwayCB1.Name;
            Owner.AwayCB1.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayCB1.Id);
            Owner.AwayCB2.Text = AwayCB2.Name;
            Owner.AwayCB2.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayCB2.Id);
            Owner.AwayRB.Text = AwayRB.Name;
            Owner.AwayRB.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayRB.Id);
            Owner.AwayLCM.Text = AwayLCM.Name;
            Owner.AwayLCM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayLCM.Id);
            Owner.AwayCM.Text = AwayCM.Name;
            Owner.AwayCM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayCM.Id);
            Owner.AwayRCM.Text = AwayRCM.Name;
            Owner.AwayRCM.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayRCM.Id);
            Owner.AwayLW.Text = AwayLW.Name;
            Owner.AwayLW.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayLW.Id);
            Owner.AwayST.Text = AwayST.Name;
            Owner.AwayST.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayST.Id);
            Owner.AwayRW.Text = AwayRW.Name;
            Owner.AwayRW.ImageSource = DataBase.DataBaseManager.GetPlayerImageSource(AwayRW.Id);
        }
    }
}