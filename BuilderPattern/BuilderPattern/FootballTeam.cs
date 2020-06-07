using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class FootballTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }
        public int TotalPlayer { get; set; }
        public string CoachName { get; set; }
        public string StarPlayer { get; set; }
        public int TotalCost { get; set; }
        public int TotalIncome { get; set; }
        public bool IsChampion { get; set; }
    }
}
