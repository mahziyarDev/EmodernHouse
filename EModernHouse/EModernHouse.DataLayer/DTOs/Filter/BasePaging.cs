using System.Linq;
using System.Security.Cryptography;

namespace EModernHouse.DataLayer.DTOs.Filter
{
    public class BasePaging
    {
        public BasePaging()
        {
            HowManyShowAfterAndBefore = 3;
        }
        public int DataCount { get; set; }
        public int PageId { get; set; }
        public int PageCount { get; set; }
        public int Take { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public int HowManyShowAfterAndBefore { get; set; }
        public void GeneratePaging(IQueryable<object> data, int pageId, int take)
        {
            DataCount = data.Count();
            PageId = pageId;
            Take = take;
            PageCount = data.Count() / take;
            if (data.Count() % 2 > 0)
            {
                PageCount += 1;
            }

            StartPage = ((PageId - HowManyShowAfterAndBefore <= 0) ? 1 : pageId - HowManyShowAfterAndBefore);
            EndPage = ((pageId + HowManyShowAfterAndBefore > PageCount) ? PageCount : pageId + HowManyShowAfterAndBefore);
        }
    }
}