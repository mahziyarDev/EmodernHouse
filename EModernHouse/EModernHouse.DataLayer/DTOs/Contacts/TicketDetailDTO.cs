using System.Collections.Generic;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.DataLayer.Entities.Contacts;

namespace EModernHouse.DataLayer.DTOs.Contacts
{
    public class TicketDetailDTO
    {
        public Ticket Ticket { get; set; }

        public List<TicketMessage> TicketMessages { get; set; }
    }
}