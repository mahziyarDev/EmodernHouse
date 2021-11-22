using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Comment;
using EModernHouse.DataLayer.DTOs.Contacts;
using EModernHouse.DataLayer.DTOs.Paging;
using EModernHouse.DataLayer.Entites.Contacts;
using EModernHouse.DataLayer.Entities.Contacts;
using EModernHouse.DataLayer.Entities.ProductComment;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;


namespace EModernHouse.Application.Services.Implementations
{
    public class ContactService : IContactService
    {
        #region constructor

        private readonly IGenericRepository<ContactUs> _contactUsRepository;
        private readonly IGenericRepository<Ticket> _ticketRepository;
        private readonly IGenericRepository<TicketMessage> _ticketMessageRepository;
        private readonly IGenericRepository<ProductComment> _productCommentRepository;
        
        public ContactService(IGenericRepository<ContactUs> contactUsRepository,
            IGenericRepository<Ticket> ticketRepository, IGenericRepository<TicketMessage> ticketMessageRepository,
            IGenericRepository<ProductComment> productCommentRepository)
        {
            _contactUsRepository = contactUsRepository;
            _ticketRepository = ticketRepository;
            _ticketMessageRepository = ticketMessageRepository;
            _productCommentRepository = productCommentRepository;
        }

        #endregion

        #region contact us

        public async Task CreateContactUs(CreateContactUsDTO contact, string userIp, long? userId)
        {
            var newContact = new ContactUs
            {
                UserId = userId != null && userId.Value != 0 ? userId.Value : (long?) null,
                Subject = contact.Subject,
                Email = contact.Email,
                UserIp = userIp,
                Text = contact.Text,
                FullName = contact.FullName
            };

            await _contactUsRepository.AddEntity(newContact);
            await _contactUsRepository.SaveChanges();
        }

        #endregion

        #region ticket

        public async Task<AddTicketResult> AddUserTicket(AddTicketViewModel ticket, long userId)
        {
            if (string.IsNullOrEmpty(ticket.Text)) return AddTicketResult.Error;

            // add ticket
            var newTicket = new Ticket
            {
                OwnerId = userId,
                IsReadByOwner = true,
                TicketPriority = ticket.TicketPriority,
                Title = ticket.Title,
                TicketSection = ticket.TicketSection,
                TicketState = TicketState.UnderProgress
            };

            await _ticketRepository.AddEntity(newTicket);
            await _ticketRepository.SaveChanges();

            // add ticket message
            var newMessage = new TicketMessage
            {
                TicketId = newTicket.Id,
                Text = ticket.Text,
                SenderId = userId,
            };

            await _ticketMessageRepository.AddEntity(newMessage);
            await _ticketMessageRepository.SaveChanges();

            return AddTicketResult.Success;
        }

        public async Task<FilterTicketDTO> FilterTickets(FilterTicketDTO filter)
        {
            var query = _ticketRepository.GetQuery().AsQueryable();

            #region State

            switch (filter.FilterTicketState)
            {
                case FilterTicketState.All:
                    break;
                case FilterTicketState.Deleted:
                    query = query.Where(q => q.IsDelete);
                    break;
                case FilterTicketState.NotDeleted:
                    query = query.Where(q => !q.IsDelete);
                    break;

            }

            #endregion

            #region OrderBy

            switch (filter.OrderBy)
            {
                case FilterTicketOrder.CreateDate_ASC:
                    query = query.OrderBy(s => s.CreateDate);
                    break;
                case FilterTicketOrder.CreateDate_DES:
                    query = query.OrderByDescending(s => s.CreateDate);
                    break;
            }

            #endregion

            #region filter_priorityAndSection

            if (filter.TicketSection != null)
            {
                query = query.Where(s => s.TicketSection == filter.TicketSection.Value);
            }

            if (filter.TicketPriority != null)
            {
                query = query.Where(s => s.TicketPriority == filter.TicketPriority.Value);
            }

            if (filter.UserId != null && filter.UserId != 0)
            {
                query = query.Where(q => q.OwnerId == filter.UserId.Value);
            }

            if (!string.IsNullOrEmpty(filter.Title))
            {
                query = query.Where(s => EF.Functions.Like(s.Title, $"%{filter.Title}%"));
            }

            #endregion

            #region Paging

            var pager = Pager.Build(filter.PageId, await query.CountAsync(), filter.TakeEntity,
                filter.HowManyPageAfterAndBefore);
            var allEntities = await query.Paging(pager).ToListAsync();

            #endregion

            return filter.setPaging(pager).setTickets(allEntities);
        }

        public async Task<TicketDetailDTO> GetTicketForShow(long ticketId, long userId)
        {
            var ticket = await _ticketRepository.GetQuery().AsQueryable()
                .Include(s => s.Owner)
                .SingleOrDefaultAsync(s => s.Id == ticketId);

            if (ticket == null || ticket.OwnerId != userId) return null;

            return new TicketDetailDTO
            {
                Ticket = ticket,
                TicketMessages = await _ticketMessageRepository.GetQuery().AsQueryable()
                    .OrderByDescending(s => s.CreateDate)
                    .Where(s => s.TicketId == ticketId && !s.IsDelete).ToListAsync()
            };
        }

        public async Task<AnswerTicketResult> AnswerTicket(AnswerTicketDTO answer, long userId)
        {
            var ticket = await _ticketRepository.GetEntityById(answer.Id);
            if (ticket == null) return AnswerTicketResult.NotFound;
            if (ticket.OwnerId != userId) return AnswerTicketResult.NotForUser;

            var ticketMessage = new TicketMessage
            {
                TicketId = ticket.Id,
                SenderId = userId,
                Text = answer.Text,

            };

            await _ticketMessageRepository.AddEntity(ticketMessage);
            await _ticketMessageRepository.SaveChanges();
            ticket.IsReadByAdmin = false;
            ticket.IsReadByOwner = true;
            await _ticketRepository.SaveChanges();
            return AnswerTicketResult.Success;

        }


        #endregion

        #region comment

        public async Task<List<ProductComment>> ShowProductCommentByProductId(long productId)
        {
            var comments = await _productCommentRepository.GetQuery().AsQueryable()
                .Where(s => s.ProductId == productId && s.ProductCommentState == ProductCommentState.Accepted)
                .Include(s => s.User)
                .ToListAsync();
            return comments;
        }

        public async Task<bool> CreateComment(CreateCommentDTO create, long userId)
        {
            var newComment = new ProductComment
            {
                ProductId = create.ProductId,
                EmailUser = create.EmailUser,
                TextComment = create.TextComment,
                TitleComment = create.TitleComment,
                UserId = userId,
                ProductCommentState = ProductCommentState.UnderProgress
            };
            await _productCommentRepository.AddEntity(newComment);
            await _productCommentRepository.SaveChanges();
            return true;
        }

        public async Task<List<ProductComment>> ShowCommentsForUser(long userId)
        {
            return await _productCommentRepository.GetQuery().AsQueryable()
                .Include(s=>s.Product)
                .Where(s => s.UserId == userId && !s.IsDelete)
                .ToListAsync();
        }

        public async Task<bool> DeleteComment(long userId, long commentId)
        {
            var comment = await _productCommentRepository.GetEntityById(commentId);
            if (comment == null) return false;
            if (comment.UserId == userId)
            {
                comment.IsDelete = true;
                _productCommentRepository.EditEntity(comment);
                await _productCommentRepository.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<List<ProductComment>> ShowNewCommentForAdmin()
        {
            return await _productCommentRepository.GetQuery().AsQueryable()
                .Where(s => !s.IsDelete && s.ProductCommentState == ProductCommentState.UnderProgress)
                .Include(s=>s.User)
                .ToListAsync();
        }

        public async Task<ProductComment> ShowCommentByIdForAdmin(long commentId)
        {
            return await _productCommentRepository.GetQuery().AsQueryable()
                .Include(s => s.User)
                .SingleOrDefaultAsync(s => s.Id == commentId);

        }

        public async Task<bool> AcceptStateComment(long commentId)
        {
            var comment = await _productCommentRepository.GetEntityById(commentId);
            if (comment == null) return false;
            comment.ProductCommentState = ProductCommentState.Accepted;
            _productCommentRepository.EditEntity(comment);
            await _productCommentRepository.SaveChanges();
            return true;
        }

        public async Task<bool> RejectStateComment(long commentId)
        {
            var comment = await _productCommentRepository.GetEntityById(commentId);
            if (comment == null) return false;
            comment.ProductCommentState = ProductCommentState.Rejected;
            _productCommentRepository.EditEntity(comment);
            await _productCommentRepository.SaveChanges();
            return true;
        }
        #endregion

        #region ticketForAdmin

        public async Task<List<Ticket>> GetTicketsSupport()
        {
            return await _ticketRepository.GetQuery().AsQueryable()
                .Where(s => s.TicketSection == TicketSection.Support && s.TicketState != TicketState.Closed)
                .Include(s => s.Owner)
                .ToListAsync();
        }

        public async Task<List<Ticket>> GetTicketTechnical()
        {
            return await _ticketRepository.GetQuery().AsQueryable()
                .Where(s => s.TicketSection == TicketSection.Technical && s.TicketState != TicketState.Closed)
                .Include(s => s.Owner)
                .ToListAsync();
        }

        public async Task<List<Ticket>> GetTicketAcademy()
        {
            return await _ticketRepository.GetQuery().AsQueryable()
                .Where(s => s.TicketSection == TicketSection.Academic && s.TicketState != TicketState.Closed)
                .Include(s => s.Owner)
                .ToListAsync();
        }

        public async Task<ShowTicketMessagesDTO> GetMessagesById(long ticketId)
        {
            var messages = await _ticketMessageRepository.GetQuery().AsQueryable()
                .Where(s => s.TicketId == ticketId)
                .ToListAsync();
            var ticket = await _ticketRepository.GetQuery().AsQueryable()
                .Include(s => s.Owner)
                .SingleOrDefaultAsync(s => s.Id == ticketId);

            ticket.IsReadByAdmin = true;
            _ticketRepository.EditEntity(ticket);
            await _ticketRepository.SaveChanges();
            return new ShowTicketMessagesDTO
            {
                Avatar = ticket.Owner.Avatar,
                FirstName = ticket.Owner.FirstName,
                LastName = ticket.Owner.LastName,
                Ticket = ticket,
                TicketMessages = messages
            };
        }

        public async Task<bool> AnswerTicket(TicketMessage message)
        {
            var newMessage = new TicketMessage
            {
                TicketId = message.TicketId,
                SenderId = message.SenderId,
                Text = message.Text,
            };
            await _ticketMessageRepository.AddEntity(newMessage);
            var ticket = await _ticketRepository.GetEntityById(message.TicketId);
            ticket.TicketState = TicketState.UnderProgress;
            ticket.IsReadByOwner = false;
            _ticketRepository.EditEntity(ticket);
            await _ticketMessageRepository.SaveChanges();
            return true;
        }
        #endregion

        #region dispose

        public async ValueTask DisposeAsync()
        {
            await _contactUsRepository.DisposeAsync();
        }

        #endregion
    }
}
