using Goalscore.Views;
using Goalscore.Views.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goalscore.ViewModels
{
    public class AuthorizationViewModel : WindowViewModel<AuthorizationWindow>
    {
        public AuthorizationViewModel(AuthorizationWindow owner) : base(owner)
        {
            SetFrame(0);
        }


        public void SetFrame(int id)
        {
            switch (id)
            {
                case 0:
                    Owner.AuthorizationFrame.Content = new Login(Owner);
                    break;
                case 1:
                    Owner.AuthorizationFrame.Content = new Registration(Owner);
                    break;
            }
        }
    }
}
