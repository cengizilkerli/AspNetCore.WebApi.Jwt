using System.Net.Http;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.ApiServices.Interfaces
{
    public interface IAuthService
    {
        Task<bool> LogIn(AppUserLogin appUserLogin);

        Task<HttpResponseMessage> GetActiveUser(string token);
        void LogOut();
    }
}