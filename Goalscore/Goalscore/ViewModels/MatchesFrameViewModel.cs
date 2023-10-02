using Goalscore.Commands;
using Goalscore.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Goalscore.ViewModels
{
    public enum MatchesType
    {
        TIMED,
        FINISHED
    }
    public class MatchesFrameViewModel : FrameViewModel<MatchesFrame, MainWindow>
    {
        private MatchesType m_type = MatchesType.TIMED;
        public MatchesType MatchesType { get { return m_type; }
            set
            { 
                if(m_type == value)
                    return;
                m_type = value;
                OnPropertyChanged(nameof(MatchesType));
                OnPropertyChanged("IsTimedMatches");
                OnPropertyChanged("IsFinishedMatches");
            }
        }
        public bool IsTimedMatches
        {
            get { return MatchesType == MatchesType.TIMED; }
            set { MatchesType = value ? MatchesType.TIMED : MatchesType; }
        }

        public bool IsFinishedMatches
        {
            get { return MatchesType == MatchesType.FINISHED; }
            set { MatchesType = value ? MatchesType.FINISHED : MatchesType; }
        }

        MatchesFinishedFrame mff;
        MatchesTimedFrame mtf;
        public MatchesFrameViewModel(MatchesFrame owner, MainWindow window) : base(owner, window)
        {
            mff = new MatchesFinishedFrame(Owner);
            mtf = new MatchesTimedFrame(Owner); 
            
            Owner.MatchFrame.Content = mtf;
        }
        private RelayCommand setFinishedMatchesCommand;
        private RelayCommand setTimedMatchesCommand;
        public RelayCommand SetFinishedMatchesCommand
        {
            get
            {
                return setFinishedMatchesCommand ??
                  (setFinishedMatchesCommand = new RelayCommand(obj =>
                  {
                      Owner.MatchFrame.Content = mff;
                  }));
            }
        }
        public RelayCommand SetTimedMatchesCommand
        {
            get
            {
                return setTimedMatchesCommand ??
                  (setTimedMatchesCommand = new RelayCommand(obj =>
                  {
                      Owner.MatchFrame.Content = mtf;
                  }));
            }
        }
    }
}