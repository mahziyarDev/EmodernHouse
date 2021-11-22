using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Comment;
using EModernHouse.DataLayer.DTOs.Contacts;
using EModernHouse.DataLayer.Entities.Contacts;
using EModernHouse.DataLayer.Entities.ProductComment;
using Microsoft.EntityFrameworkCore.Diagnostics;


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

        #region comment

        Task<List<ProductComment>> ShowProductCommentByProductId(long productId);
        Task<bool> CreateComment(CreateCommentDTO create, long userId);
        Task<List<ProductComment>> ShowCommentsForUser(long userId);
        Task<bool> DeleteComment(long userId, long commentId);
        Task<List<ProductComment>> ShowNewCommentForAdmin();
        Task<ProductComment> ShowCommentByIdForAdmin(long commentId);
        Task<bool> AcceptStateComment(long commentId);
        Task<bool> RejectStateComment(long commentId);
        #endregion

        #region ticketForAdmin

        Task<List<Ticket>> GetTicketsSupport();
        Task<List<Ticket>> GetTicketTechnical();
        Task<List<Ticket>> GetTicketAcademy();
        Task<ShowTicketMessagesDTO> GetMessagesById(long ticketId);
        Task<bool> AnswerTicket(TicketMessage message);

        #endregion
    }
}