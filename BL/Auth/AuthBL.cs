using ResumeNET.DAL.Models;
using ResumeNET.DAL;

namespace ResumeNET.BL.Auth
{
    public class AuthBL : IAuthBL
    {
        private readonly IAuthDAL _authDAL;

        public AuthBL(IAuthDAL authDal)
        {
            this._authDAL = authDal;
        }
        public async Task<int> CreateUser(UserModel user)
        {
            return await _authDAL.CreateUser(user);
        }
    }
}
