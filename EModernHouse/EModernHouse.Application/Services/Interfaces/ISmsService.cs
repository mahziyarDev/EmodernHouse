using System.Threading.Tasks;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface ISmsService
    {
        Task SendVerificationSms(string mobile, string activationCode);
        Task SendSmsInAdmin(string mobile, string shortText);
    }
}