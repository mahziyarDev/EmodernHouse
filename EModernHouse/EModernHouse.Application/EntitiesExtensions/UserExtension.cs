using EModernHouse.DataLayer.Entities.Account;

namespace EModernHouse.Application.EntitiesExtensions
{
    public static class UserExtension
    {
        public static string GetUserShowName(this User user)
        {
            if (!string.IsNullOrEmpty(user.FirstName) && !string.IsNullOrEmpty(user.LastName))
            {
                return $"{user.FirstName} {user.LastName}";
            }

            return user.Mobile;
        }
    }
}