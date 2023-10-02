using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballDataApi.Models;

namespace Goalscore.Model
{
    public class UserFavoritePlayers
    {
        [Key]
        public int Id { get; set; }
        public string UserNickName { get; set; }
        public User User { get; set; }
        public int? PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
