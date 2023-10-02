using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goalscore.Model
{
    public class User
    {
        [NotMapped]
        public static User current;
        [Key]
        public string NickName { get; set; }
        public string Password { get; set; }
        public string ProfileIamge { get; set; }
    }
}
