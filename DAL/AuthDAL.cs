using ResumeNET.DAL.Models;
using Dapper;
using Npgsql;

namespace ResumeNET.DAL
{
    public class AuthDAL : IAuthDAL
    {
        public async Task<UserModel> GetUser(string email)
        {
            using (var connection = new NpgsqlConnection(DbHelper.connString))
            {
                connection.Open();
                return await connection.QueryFirstOrDefaultAsync<UserModel>(@"
                    select UserId, Email, Password, Salt, Status 
                    from appuser
                    where Email = @email", new { email }) ?? new UserModel();
            }
        }

        public async Task<UserModel> GetUser(int id)
        {
            using (var connection = new NpgsqlConnection(DbHelper.connString))
            {
                connection.Open();
                return await connection.QueryFirstOrDefaultAsync<UserModel>(@"
                    select UserId, Email, Password, Salt, Status 
                    from appuser
                    where UserId = @id", new { id }) ?? new UserModel();
            }
        }

        public async Task<int> CreateUser(UserModel model)
        {
            using (var connection = new NpgsqlConnection(DbHelper.connString))
            {
                connection.Open();
                string sql = @"insert into appuser(Email, Password, Salt, Status)
                        values(@Email, @Password, @Salt, @Status)";
                return await connection.ExecuteAsync(sql, model);
            }
        }
    }
}
