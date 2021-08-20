using System;
using System.Threading.Tasks;
using EModernHouse.DataLayer.DTOs.Contacts;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface IContactService : IAsyncDisposable
    {
        Task CreateContactUs(CreateContactUsDTO contact,string userIp,long? userId);
    }
}