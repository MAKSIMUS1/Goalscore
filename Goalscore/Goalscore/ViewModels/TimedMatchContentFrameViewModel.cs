using Goalscore.Views;
using Goalscore.Views.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goalscore.ViewModels
{
    public class TimedMatchContentFrameViewModel : FrameViewModel<TimedMatchContentFrame, TimedMatchWindow>
    {
        public TimedMatchContentFrameViewModel(TimedMatchContentFrame owner, TimedMatchWindow window, MatchTimed matchTimed) : base(owner, window)
        {
            Owner.RefereeTextBlock.Text = DataBase.DataBaseManager.Instance.refereeSet.ToList().Where(x => x.Id == matchTimed.RefereeId).Single().Name;
            Owner.StadiumTextBlock.Text = DataBase.DataBaseManager.Instance.teamSet.ToList().Where(x => x.Id == matchTimed.HomeTeam.Id).Single().Address;
        }
    }
}
