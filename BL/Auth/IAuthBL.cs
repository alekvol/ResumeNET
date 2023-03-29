using ResumeNET.DAL.Models;
namespace ResumeNET.BL.Auth
{
    public interface IAuthBL
    {
        Task<int> CreateUser (UserModel user);
    }
}
