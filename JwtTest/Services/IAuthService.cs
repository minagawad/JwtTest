using JwtTest.Model;
using System.Threading.Tasks;

namespace JwtTest.Services
{
    public interface IAuthService
    {

        Task<AuthModel> RegisterAsync(RegisterModel model);

    }
}
