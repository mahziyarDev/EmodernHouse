using System.Collections.Generic;
using EModernHouse.DataLayer.DTOs.Account;
using EModernHouse.DataLayer.DTOs.Paging;
using EModernHouse.DataLayer.Entities.Contacts;

namespace EModernHouse.DataLayer.DTOs.Contacts
{
    public class FilterTicketDTO : BasePaging
    {
        #region Property

        public string Title { get; set; }
        public long? UserId { get; set; }

        public TicketSection? TicketSection { get; set; }
        public TicketPriority? TicketPriority { get; set; }

        public FilterTicketState FilterTicketState { get; set; }
        public FilterTicketOrder OrderBy { get; set; }
        public List<Ticket> Tickets { get; set; }

        #endregion

        #region methods

        public FilterTicketDTO setTickets(List<Ticket> tickets)
        {
            this.Tickets = tickets;
            return this;
        }

        public FilterTicketDTO setPaging(BasePaging paging)
        {
            this.PageId = paging.PageId;
            this.AllEntitiesCount = paging.AllEntitiesCount;
            this.StartPage = paging.StartPage;
            this.EndPage = paging.EndPage;
            this.HowManyPageAfterAndBefore = paging.HowManyPageAfterAndBefore;
            this.TakeEntity = paging.TakeEntity;
            this.SkipEntity = paging.SkipEntity;
            this.PageCount = paging.PageCount;
            return this;
        }

        #endregion
    }

    #region Enums

    public enum FilterTicketState
    {
        All,
        NotDeleted,
        Deleted
    }

    public enum FilterTicketOrder
    {
        CreateDate_ASC,
        CreateDate_DES
    }
    #endregion
}