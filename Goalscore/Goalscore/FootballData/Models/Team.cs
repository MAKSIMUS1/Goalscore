using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballDataApi.Models
{
    public class Team
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Id { get; set; }
        public int? AreaId { get; set; }
        public Area Area { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Tla { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public int? Founded { get; set; }
        public string ClubColors { get; set; }
        public object Venue { get; set; }
        public IEnumerable<Player> Squad { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated { get; set; }
    }
}
