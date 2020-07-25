using BattleShip.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.WEB.Models
{
    public class StatisticsViewModel
    {
        public IEnumerable<StatisticsRecord> StatisticsRecords { get; set; }
        public SortedStatisticsRecord SortedStatisticsRecord { get; set; }
        public FilterStatisticsRecord FilterStatisticsRecord { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
