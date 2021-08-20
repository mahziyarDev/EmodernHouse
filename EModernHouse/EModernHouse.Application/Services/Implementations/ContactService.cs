using System.Threading.Tasks;
using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Contacts;
using EModernHouse.DataLayer.Entites.Contacts;
using EModernHouse.DataLayer.Repository;

namespace EModernHouse.Application.Services.Implementations
{
    public class ContactService : IContactService
    {
        #region Ctor

        private readonly IGenericRepository<ContactUs> _contactUsRepository;

        public ContactService(IGenericRepository<ContactUs> contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }


        #endregion

        #region Contact us

        public async Task CreateContactUs(CreateContactUsDTO contact, string userIp, long? userId)
        {
            var newContact = new ContactUs
            {
                UserId = userId != null && userId.Value != 0 ? userId.Value : (long?)null,
                Subject = contact.Subject,
                Text = contact.Text,
                Email = contact.Email,
                Mobile = contact.Mobile,
                FullName = contact.FullName,
                UserIp = userIp
            };

            await _contactUsRepository.AddEntity(newContact);
            await _contactUsRepository.SaveChanges();
        }

        #endregion

        #region Disposiable

        public async ValueTask DisposeAsync()
        {
            await _contactUsRepository.DisposeAsync();
        }

        #endregion

    }
}