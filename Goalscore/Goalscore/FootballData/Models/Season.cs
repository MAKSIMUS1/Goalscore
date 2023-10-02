using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballDataApi.Models
{
    public class Season
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? EndDate { get; set; }
        public int? CurrentMatchday { get; set; }
        public string[] AvailableStages { get; set; }
    }
}
