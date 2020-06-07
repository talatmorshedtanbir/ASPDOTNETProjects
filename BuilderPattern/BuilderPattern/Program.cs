using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var footballTeam = new TeamBuilder(1, "Real Madrid", "Spain")
                                                     .SetCoach("Zinedin Zidan")
                                                     .SetPlayerNo(25)
                                                     .SetStarPlayer("Ronaldo")
                                                     .SetTotalCost(200)
                                                     .SetTotalIncome(600)
                                                     .SetChampion(true)
                                                     .Build();

            Console.WriteLine($"A team with no {footballTeam.Id} has registered\nTeam Name is {footballTeam.Name}. It a club from {footballTeam.CountryName}." +
                $"Coach is {footballTeam.CoachName}");
            if (footballTeam.IsChampion)
                Console.WriteLine("It is the champion of EUROPE.");
            else 
                Console.WriteLine("It is not current champion");
        }
    }
}
