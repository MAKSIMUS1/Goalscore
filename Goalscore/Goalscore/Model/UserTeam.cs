using FootballDataApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goalscore.Model
{
    public class UserTeam
    {

        [Key]
        public int Id { get; set; }
        public string UserNickName { get; set; }
        public User User { get; set; }
        //Squad
        public int? GKId { get; set; }
        public Player GK { get; set; }
        public int? LBId { get; set; }
        public Player LB { get; set; }
        public int? CB1Id { get; set; }
        public Player CB1 { get; set; }
        public int? CB2Id { get; set; }
        public Player CB2 { get; set; }
        public int? RBId { get; set; }
        public Player RB { get; set; }
        public int? LCMId { get; set; }
        public Player LCM { get; set; }
        public int? CMId { get; set; }
        public Player CM { get; set; }
        public int? RCMId { get; set; }
        public Player RCM { get; set; }
        public int? LWId { get; set; }
        public Player LW { get; set; }
        public int? STId { get; set; }
        public Player ST { get; set; }
        public int? RWId { get; set; }
        public Player RW { get; set; }
    }
}
