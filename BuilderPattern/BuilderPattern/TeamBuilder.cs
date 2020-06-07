using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class TeamBuilder
    {
        private FootballTeam team;

        public TeamBuilder(int id, string name, string countryName)
        {
            team = new FootballTeam();
            team.Id = id;
            team.Name = name;
            team.CountryName = countryName;
        }


        public TeamBuilder SetPlayerNo(int players)
        {
            team.TotalPlayer = players;
            return this;
        }

        public TeamBuilder SetCoach(string coachName )
        {
            team.CoachName = coachName;
            return this;
        }

        public TeamBuilder SetStarPlayer(string starName )
        {
            team.StarPlayer = starName;
            return this;
        }

        public TeamBuilder SetTotalCost(int cost)
        {
            team.TotalCost = cost;
            return this;
        }

        public TeamBuilder SetTotalIncome(int income)
        {
            team.TotalIncome = income;
            return this;
        }

        public TeamBuilder SetChampion(bool isChampion)
        {
            team.IsChampion = isChampion;
            return this;
        }

        public FootballTeam Build()
        {
            return team;
        }
    }
}
