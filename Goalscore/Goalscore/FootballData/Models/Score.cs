using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballDataApi.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public int? HalfTimeId { get; set; }
        public GoalScore HalfTime { get; set; }
        public int? FullTimeId { get; set; }
        public GoalScore FullTime { get; set; }
        public int? ExtraTimeId { get; set; }
        public GoalScore ExtraTime { get; set; }
        public int? PenaltiesId { get; set; }
        public GoalScore Penalties { get; set; }
    }

}
