using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Comment;
using EModernHouse.DataLayer.DTOs.Contacts;
using EModernHouse.DataLayer.Entities.ProductComment;


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

        #region comment

        Task<List<ProductComment>> ShowProductCommentByProductId(long productId);
        Task<bool> CreateComment(CreateCommentDTO create, long userId);

        #endregion
    }
}