using BattleShip.BusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BattleShip.WEB.Models
{
    public class FilterStatisticsRecord
    {
        public string SelectedName { get; private set; }
        public bool OnlyIntactShips { get; private set; }
        public FilterMoveState FilterMoveState { get; private set; }

        public FilterStatisticsRecord(string name, FilterMoveState filterMoveState, bool onlyIntactShips)
        {
            this.SelectedName = name;
            this.OnlyIntactShips = onlyIntactShips;
            this.FilterMoveState = filterMoveState;
        }


    }
}
