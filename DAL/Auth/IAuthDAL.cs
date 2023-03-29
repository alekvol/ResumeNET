﻿using ResumeNET.DAL.Models;
namespace ResumeNET.DAL.Auth
{
    public interface IAuthDAL
    {
        Task<UserModel> GetUser(string email);
        Task<UserModel> GetUser(int id);
        Task<int> CreateUser(UserModel model);
    }
}
