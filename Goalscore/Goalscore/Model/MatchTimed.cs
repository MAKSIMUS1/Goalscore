﻿using FootballDataApi.Models;
using Goalscore.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Goalscore.ViewModels
{
    public class MatchTimed : BaseViewModel
    {
        public MatchTimed(int? matchId, string competitionName, DateTime utcDate, string status, int? homeTeamId, int? awayTeamId, int? scoreId, int? refereeId, DateTime lastUpdated, string areaName)
        {
            MatchId = matchId;
            CompetitionName = competitionName;
            UtcDate = utcDate;
            Status = status;
            HomeTeamId = homeTeamId;
            AwayTeamId = awayTeamId;
            ScoreId = scoreId;
            RefereeId = refereeId;
            LastUpdated = lastUpdated;
            AreaName = areaName;
        }

        private Team _homeTeam { get {
                MatchTeam homeTeam = DataBase.DataBaseManager.Instance.matchTeamSet.ToList().Where(p => p.Id == HomeTeamId).Single();
                if (homeTeam.TeamId != null)
                    return DataBase.DataBaseManager.Instance.teamSet.ToList().Where(p => p.Id == homeTeam.TeamId).Single();
                return null;
                } }
        private Team _awayTeam { get
            {
                MatchTeam awayTeam = DataBase.DataBaseManager.Instance.matchTeamSet.ToList().Where(p => p.Id == AwayTeamId).Single();
                if (awayTeam.TeamId != null)
                    return DataBase.DataBaseManager.Instance.teamSet.ToList().Where(p => p.Id == awayTeam.TeamId).Single();
                return null;
            } }
        public Team HomeTeam
        {
            get
            {
                return _homeTeam;
            }
        }
        public Team AwayTeam
        {
            get
            {
                return _awayTeam;
            }
        }
        public string HomeTeamName { get { 
                if(HomeTeam != null)
                    return HomeTeam.Name; 
                else return "none";
            } }
        public string AwayTeamName { get
            {
                if (AwayTeam != null)
                    return AwayTeam.Name;
                else return "none";
            } }
        public int? MatchId { get; }
        public string CompetitionName { get; }
        public DateTime UtcDate { get; }
        public string Status { get; } 
        public int? HomeTeamId { get; }
        public int? AwayTeamId { get; }
        public int? ScoreId { get; }
        public int? RefereeId { get; }
        public DateTime LastUpdated { get; }
        public string AreaName;
        public string TeamHomeImage 
        {
            get 
            {
                return DataBase.DataBaseManager.GetTeamImageSource(HomeTeam.Id).Insert(0, "../");
            }
        }
        public string AwayHomeImage
        {
            get
            {
                return DataBase.DataBaseManager.GetTeamImageSource(AwayTeam.Id).Insert(0, "../");
            }
        }
    }
}
