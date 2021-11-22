using System.Threading.Tasks;
using Kavenegar;
using EModernHouse.Application.Services.Interfaces;

namespace EModernHouse.Application.Services.Implementations
{
    public class SmsService : ISmsService
    {
        private string ApiKey =
            "696869693336714E325077666B335034416D506D41456C756B49434A4C72795558556B62696C50647A65733D";

        public async Task SendVerificationSms(string mobile, string activationCode)
        {
            Kavenegar.KavenegarApi api = new Kavenegar.KavenegarApi(ApiKey);
            await api.VerifyLookup(mobile, activationCode, "EmodernHouseVerify");
        }

        public async Task SendSmsInAdmin(string mobile, string shortText)
        {
            Kavenegar.KavenegarApi api = new KavenegarApi(ApiKey);
            await api.VerifyLookup(mobile, shortText, "SendSmsToUser");
        }
    }
}