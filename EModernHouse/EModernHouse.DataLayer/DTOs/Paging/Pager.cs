using System;

namespace EModernHouse.DataLayer.DTOs.Paging
{
    public class Pager
    {
        public static BasePaging Build(int pageId,int allEntitiesCount,int take,int HowManyPageAfterAndBefore)
        {
            var pageCount = Convert.ToInt32(Math.Ceiling(allEntitiesCount / (double)take));
            return new BasePaging
            {
                PageId = pageId,
                AllEntitiesCount = allEntitiesCount,
                TakeEntity = take,
                SkipEntity =  (pageId - 1) * take,
                StartPage = pageId - HowManyPageAfterAndBefore <= 0 ? 1:pageId - HowManyPageAfterAndBefore,
                EndPage =pageId + HowManyPageAfterAndBefore > pageCount ? pageId : pageId + HowManyPageAfterAndBefore,
                HowManyPageAfterAndBefore = HowManyPageAfterAndBefore,
                PageCount = pageCount,
                
            };
        }
    }
}