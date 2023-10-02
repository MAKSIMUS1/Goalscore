using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballDataApi.Models
{
    public class SeasonStanding
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public Season Season { get; set; }
        public IEnumerable<Standing> Standings { get; set; }
    }
}
