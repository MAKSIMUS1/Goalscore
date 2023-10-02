using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Goalscore.DataBase;
using System.Linq;

namespace FootballDataApi.Models
{
    public class Player
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int? ShirtNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string CountryOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Role { get; set; }
        public int? TeamId { get; set; }
        public Team Team { get; set; }
        [NotMapped]
        public string PlayerImage 
        {
            get
            {
                return DataBaseManager.GetPlayerImageSource(this.Id).Insert(0, "../");
            }
        }
        [NotMapped]
        public string TeamName
        {
            get
            {
                return DataBaseManager.Instance.teamSet.ToList().Where(t => t.Id == this.TeamId).Single().Name;
            }
        }
        [NotMapped]
        public string TeamImage
        {
            get
            {
                return DataBaseManager.GetTeamImageSource(this.TeamId).Insert(0, "../");
            }
        }
        [NotMapped]
        public string NationalityImage
        {
            get
            {
                return DataBaseManager.GetNationalityImageSource(this.Nationality).Insert(0, "../");
            }
        }
        [NotMapped]
        public string ShortDateOfBirth
        {
            get
            {
                DateTime d = (DateTime)DateOfBirth;
                return d.ToShortDateString();
            }
        }
    }

}
