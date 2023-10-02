using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FootballDataApi.Models
{
    public class Standing
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Stage { get; set; }
        public string Type { get; set; }
        public object Group { get; set; }
        public IEnumerable<Ranking> Table { get; set; }
    }
}
