using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballDataApi.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public int? Minute { get; set; }
        public int? MatchTeamId { get; set; }
        public MatchTeam Team { get; set; }
        public int? PlayerId { get; set; }
        public Player Player { get; set; }
        public string Card { get; set; }
    }

}
