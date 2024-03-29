﻿namespace EModernHouse.DataLayer.DTOs.Paging
{
    public class BasePaging
    {
        public BasePaging()
            {
                PageId = 1;
                TakeEntity = 10;
                HowManyPageAfterAndBefore = 2;
            }

            public int PageId { get; set; }

            public int PageCount { get; set; }

            public int AllEntitiesCount { get; set; }

            public int StartPage { get; set; }

            public int EndPage { get; set; }

            public int TakeEntity { get; set; }

            public int SkipEntity { get; set; }

            public int HowManyPageAfterAndBefore { get; set; }

            public BasePaging GetCurrentPaging()
            {
                return this;
            }
        }
}