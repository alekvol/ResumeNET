using ResumeNET.ViewModels;
using ResumeNET.DAL.Models;

namespace ResumeNET.ViewMapper
{
    public class AuthMapper
    {
        public static UserModel MapRegisterViewModelToUserModel(RegisterViewModel model)
        {
            return new UserModel()
            {
                Email = model.Email!,
                Password = model.Password!
            };
        } 
    }
}
