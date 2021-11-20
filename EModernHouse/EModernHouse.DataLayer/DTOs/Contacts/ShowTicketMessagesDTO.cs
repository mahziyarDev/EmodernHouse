using System.Collections.Generic;
using EModernHouse.DataLayer.Entities.Contacts;

namespace EModernHouse.DataLayer.DTOs.Contacts
{
    public class ShowTicketMessagesDTO
    {
        public string Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Ticket Ticket { get; set; }
        public List<TicketMessage> TicketMessages { get; set; }
    }
}