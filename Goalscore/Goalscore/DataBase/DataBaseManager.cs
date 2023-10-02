using FootballDataApi.Models;
using Goalscore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Goalscore.DataBase
{
    public class DataBaseManager : DbContext
    {
        public DataBaseManager() : base("Default") 
        {
            
        }
        public static DataBaseManager Instance;

        static DataBaseManager()
        {
            Instance = new DataBaseManager();
        }
        public DbSet<User> userSet { get; set; }
        public DbSet<Area> areaSet { get; set; }
        public DbSet<Booking> bookingSet { get; set; }
        public DbSet<Coach> coachSet { get; set; }
        public DbSet<Competition> competitionSet { get; set; }
        public DbSet<CompetitionMatches> competitionMatchesSet { get; set; }
        public DbSet<Goal> goalSet { get; set; }
        public DbSet<GoalScore> goalScoreSet { get; set; }
        public DbSet<Match> matchSet { get; set; }
        public DbSet<MatchTeam> matchTeamSet { get; set; }
        public DbSet<Player> playerSet { get; set; }
        public DbSet<Ranking> rankingSet { get; set; }
        public DbSet<Referee> refereeSet { get; set; }
        public DbSet<Score> scoreSet { get; set; }
        public DbSet<Season> seasonSet { get; set; }
        public DbSet<SeasonStanding> seasonStandingSet { get; set; }
        public DbSet<Standing> standingSet { get; set; }
        public DbSet<Substitution> substitutionSet { get; set; }
        public DbSet<Team> teamSet { get; set; }
        public DbSet<UserTeam> userTeamSet { get; set; }
        public DbSet<UserFavoritePlayers> userFavoritePlayersSet { get; set; }

        public static BitmapImage GetTeamImage(int? teamId)
        {
            Uri resourceUri;
            switch (teamId)
            {
                case 98:
                    resourceUri = new Uri("/Resources/AC_Milan.png", UriKind.Relative);
                    break;
                case 100:
                    resourceUri = new Uri("/Resources/AS_Roma.png", UriKind.Relative);
                    break;
                default:
                    resourceUri = new Uri("/Resources/no_image.png", UriKind.Relative);
                    break;
            }
            return new BitmapImage(resourceUri);
        }
        public static string GetPlayerImageSource(int? playerId)
        {
            string imageSource;
            switch (playerId)
            {

                case 102343:
                    imageSource = "../Resources/player_102343.png";
                    break;
                case 11:
                    imageSource = "../Resources/player_11.png";
                    break;
                case 1324:
                    imageSource = "../Resources/player_1324.png";
                    break;
                case 1337:
                    imageSource = "../Resources/player_1337.png";
                    break;
                case 146114:
                    imageSource = "../Resources/player_146114.png";
                    break;
                case 1556:
                    imageSource = "../Resources/player_1556.png";
                    break;
                case 164:
                    imageSource = "../Resources/player_164.png";
                    break;
                case 3177:
                    imageSource = "../Resources/player_3177.png";
                    break;
                case 349:
                    imageSource = "../Resources/player_349.png";
                    break;
                case 3641:
                    imageSource = "../Resources/player_3641.png";
                    break;
                case 3653:
                    imageSource = "../Resources/player_3653.png";
                    break;
                case 4147:
                    imageSource = "../Resources/player_4147.png";
                    break;
                case 43:
                    imageSource = "../Resources/player_43.png";
                    break;
                case 45:
                    imageSource = "../Resources/player_45.png";
                    break;
                case 46:
                    imageSource = "../Resources/player_46.png";
                    break;
                case 47:
                    imageSource = "../Resources/player_47.png";
                    break;
                case 49:
                    imageSource = "../Resources/player_49.png";
                    break;
                case 50:
                    imageSource = "../Resources/player_50.png";
                    break;
                case 68:
                    imageSource = "../Resources/player_68.png";
                    break;
                case 96:
                    imageSource = "../Resources/player_96.png";
                    break;
                case 8458:
                    imageSource = "../Resources/player_8458.png";
                    break;
                case 8474:
                    imageSource = "../Resources/player_8474.png";
                    break;
                case 8514:
                    imageSource = "../Resources/player_8514.png";
                    break;
                case 7888:
                    imageSource = "../Resources/player_7888.png";
                    break;

                case 143:
                    imageSource = "../Resources/player_143.png";
                    break;
                case 3182:
                    imageSource = "../Resources/player_3182.png";
                    break;
                case 3222:
                    imageSource = "../Resources/player_3222.png";
                    break;
                case 3254:
                    imageSource = "../Resources/player_3254.png";
                    break;
                case 3311:
                    imageSource = "../Resources/player_3311.png";
                    break;
                case 3313:
                    imageSource = "../Resources/player_3313.png";
                    break;
                case 3654:
                    imageSource = "../Resources/player_3654.png";
                    break;
                case 3895:
                    imageSource = "../Resources/player_3895.png";
                    break;
                case 8069:
                    imageSource = "../Resources/player_8069.png";
                    break;
                case 10183:
                    imageSource = "../Resources/player_10183.png";
                    break;
                case 38101:
                    imageSource = "../Resources/player_38101.png";
                    break;
                default:
                    imageSource = "../Resources/no_image.png";
                    break;
            }
            return imageSource;
        }
        public static string GetTeamImageSource(int? teamId)
        {
            string imageSource;
            switch (teamId)
            {
                case 65:
                    imageSource = "../Resources/Manchester_City_FC.png";
                    break;
                case 86:
                    imageSource = "../Resources/Real_Madrid.png";
                    break;
                case 98:
                    imageSource = "../Resources/AC_Milan.png";
                    break;
                case 100:
                    imageSource = "../Resources/AS_Roma.png";
                    break;
                default:
                    imageSource = "../Resources/no_image.png";
                    break;
            }
            return imageSource;
        }
        public static string GetNationalityImageSource(string nationality)
        {
                return $"../Resources/Nations/{nationality}.png";
        }
    }
}
