using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballDataApi.Models
{
    public class Coach
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Id { get; set; }
        public string Name { get; set; }
        public string CountryOfBirth { get; set; }
        public string Nationality { get; set; }
    }

}
