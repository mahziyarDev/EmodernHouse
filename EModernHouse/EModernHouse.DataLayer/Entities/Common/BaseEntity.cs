using System;

namespace EModernHouse.DataLayer.Entities.Common
{
    public class BaseEntity
    {
        public long Id { get; set; }

        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}