using System;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Contacts;


namespace EModernHouse.Application.Services.Interfaces
{
    public interface IContactService : IAsyncDisposable
    {
        #region contact us

        Task CreateContactUs(CreateContactUsDTO contact, string userIp, long? userId);


        #endregion

        #region ticket

        Task<AddTicketResult> AddUserTicket(AddTicketViewModel ticket, long userId);
        Task<FilterTicketDTO> FilterTickets(FilterTicketDTO filter);
        Task<TicketDetailDTO> GetTicketForShow(long ticketId, long userId);
        Task<AnswerTicketResult> AnswerTicket(AnswerTicketDTO answer, long userId);


        #endregion

        #region ticketForAdmin
        
        #endregion
    }
}