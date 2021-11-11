using System.Collections.Generic;

namespace EModernHouse.DataLayer.DTOs.Filter
{
    public class TicketFilterDTO : BasePaging
    {
        public List<TicketFilterDTO> MyProperty { get; set; }
    }
}
