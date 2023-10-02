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
    public class FinishedMatchContentInfoViewModel : FrameViewModel<FinishedMatchContentInfo, FinishedMatchWindow>
    {
        public FinishedMatchContentInfoViewModel(FinishedMatchContentInfo owner, FinishedMatchWindow window, MatchFinished matchFinished) : base(owner, window)
        {
            Owner.RefereeTextBlock.Text = DataBase.DataBaseManager.Instance.refereeSet.ToList().Where(x => x.Id == matchFinished.RefereeId).Single().Name;
            Owner.StadiumTextBlock.Text = DataBase.DataBaseManager.Instance.teamSet.ToList().Where(x => x.Id == matchFinished.HomeTeam.Id).Single().Address;
            Owner.AttandenceTextBlock.Text = matchFinished.Attendance.ToString();
        }
    }
}
