using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleShip.BusinessLogic.Enums;
using BattleShip.BusinessLogic.Interfaces;
using BattleShip.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace BattleShip.WEB.Controllers
{
    public class StatisticsController : Controller
    {
        IStatisticsService statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            this.statisticsService = statisticsService;
        }

        public IActionResult Statistics(int page = 1, string name = "", bool onlyIntactShips = false, FilterMoveState filterMoveState = FilterMoveState.All, SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 3;
            var records = this.statisticsService.GetStatisticsRecords(name, onlyIntactShips, sortOrder, filterMoveState);
            var count = records.Count();
            var items = records.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            StatisticsViewModel viewModel = new StatisticsViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                StatisticsRecords = items,
                SortedStatisticsRecord = new SortedStatisticsRecord(sortOrder),
                FilterStatisticsRecord = new FilterStatisticsRecord(name, filterMoveState, onlyIntactShips)
            };

            return View(viewModel);
        }
    }
}
