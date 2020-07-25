using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.WEB.Models
{
    public class PageViewModel
    {
        public int PageNumber { get; private set; }
        public int TotalPages { get; private set; }

        public PageViewModel(int count, int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (this.PageNumber > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (this.PageNumber < this.TotalPages);
            }
        }
    }
}
