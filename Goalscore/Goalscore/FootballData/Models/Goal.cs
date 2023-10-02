using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballDataApi.Models
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        public int? Minute { get; set; }
        public int? ScorerId { get; set; }
        public Player Scorer { get; set; }
        public int? AssistId { get; set; }
        public Player Assist { get; set; }
        public int? MatchId { get; set; }
        public Match Match { get; set; }
    }

}
