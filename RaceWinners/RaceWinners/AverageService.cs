using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RaceWinners.Models;

namespace RaceWinners
{
    public class AverageService
    {
        List<Group> groups = new DataService().GetGroupRanksAsync().Result;

        public List<Group> Average()
        {
            foreach (var group in groups)
            {
                group.Average = group.Ranks.Sum() / group.Ranks.Count;
            }
            return groups;
        }
    }
}
