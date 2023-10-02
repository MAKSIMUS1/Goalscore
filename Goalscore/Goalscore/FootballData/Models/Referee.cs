using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FootballDataApi.Models
{
    public class Referee
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; }
        public object Nationality { get; set; }
    }

}
