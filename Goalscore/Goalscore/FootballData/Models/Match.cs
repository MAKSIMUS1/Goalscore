using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballDataApi.Models
{
    public class Match
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Id { get; set; }
        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }
        public int SeasonId { get; set; }
        public Season Season { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime UtcDate { get; set; }
        public string Status { get; set; }
        public object Minute { get; set; }
        public int? Attendance { get; set; }
        public int? Matchday { get; set; }
        public string Stage { get; set; }
        public string Group { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated { get; set; }
        public int? HomeTeamId { get; set; }
        public MatchTeam HomeTeam { get; set; }
        public int? AwayTeamId { get; set; }
        public MatchTeam AwayTeam { get; set; }
        public int? ScoreId { get; set; }
        public Score Score { get; set; }
        public IEnumerable<Goal> Goals { get; set; }
        public IEnumerable<Booking> Bookings { get; set; }
        public IEnumerable<Substitution> Substitutions { get; set; }
        public IEnumerable<Referee> Referees { get; set; }
        public int? RefereeId { get; set; }
        public Referee Referee { get; set; }
    }
}
