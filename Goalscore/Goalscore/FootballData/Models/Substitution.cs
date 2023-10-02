using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballDataApi.Models
{
    public class Substitution
    {
        [Key]
        public int Id { get; set; }
        public int? Minute { get; set; }
        public int? MatchTeamId { get; set; }
        public MatchTeam Team { get; set; }
        public int? PlayerOutId { get; set; }
        public Player PlayerOut { get; set; }
        public int? PlayerInId { get; set; }
        public Player PlayerIn { get; set; }
    }

}
