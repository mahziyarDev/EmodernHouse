using System.Linq;
using System.Security.Cryptography;

namespace EModernHouse.DataLayer.DTOs.Filter
{
    public class BasePaging
    {
       
        public int DataCount { get; set; }
        public int PageId { get; set; }
        public int PageCount { get; set; }
        public int Take { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public void GeneratePaging(IQueryable<object> data, int pageId, int take)
        {
            DataCount = data.Count();
            PageId = pageId;
            Take = take;
            PageCount = data.Count() / take;
            if (data.Count() % take > 0)
                PageCount += 1;

            Take = take;
            StartPage = ((pageId - 2 <= 0) ? 1 : pageId - 2);
            EndPage = ((pageId + 2 > PageCount) ? PageCount : pageId + 2);
        }
    }
}