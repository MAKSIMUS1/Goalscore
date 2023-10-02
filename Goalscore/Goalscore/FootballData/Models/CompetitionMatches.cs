using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FootballDataApi.Models
{
    public class CompetitionMatches
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Count { get; set; }
        public object Filters { get; set; }
        public Season Season { get; set; }
        public IEnumerable<Match> Matches { get; set; }
    }
}
