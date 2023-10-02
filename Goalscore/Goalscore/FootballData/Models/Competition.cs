using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FootballDataApi.Models
{
    public class Competition
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int? AreaId { get; set; }
        public Area Area { get; set; }
        public string Name { get; set; }
        public object Code { get; set; }
        public string Plan { get; set; }
        public int? SeasonId { get; set; }
        public Season CurrentSeason { get; set; }
        public IEnumerable<Season> Seasons { get; set; }
        public int NumberOfAvailableSeasons { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated { get; set; }
    }
}
