using FootballDataApi.Models;
using Goalscore.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goalscore.Model
{
    public class PlayerInUserTeam
    {
        private int? _Id;
        public int? Id { 
            get { return _Id; }
            set 
            {
                _Id = value;
            }
        }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Nationality { get; set; }
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
