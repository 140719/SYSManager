using SYSManager.Application.Data.MySql.Entits;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SYSManager.Application.Data.MySql.Repositories
{
    public class UserRepository
    {
        public UserRepository()
        {

        }

        public async Task<UserEntity> CreateUser(UserEntity entity)
        {
            var _sql = @$"INSERT INTO user(id, userName, email, password, active)
                                     VALUE(@id, @userName, @email, @password, @active)";

            return new UserEntity();
        }
        public async Task<UserEntity> UpdateUser(string password, Guid id)
        {
            var _sql = @$"UPDATE user set password = '{password}' where id = '{id}'";

            return new UserEntity();
        }
        public async Task<UserEntity> GetUserByEmail(string email)
        {
            var _sql = @$"SELECT id, userName, email, password, active from user
                          WHERE email = '{email}'";
            return new UserEntity();
        }
        public async Task<UserEntity> InactiveUser(Guid id)
        {
            var _sql = @$"UPDATE user set active = false where id = '{id}'";
            return new UserEntity();
        }
    }
}
