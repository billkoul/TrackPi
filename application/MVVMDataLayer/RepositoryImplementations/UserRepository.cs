using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using MVVMEntityLayer;

namespace MVVMDataLayer
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(AdvWorksDbContext context)
        {
            DbContext = context;
        }

        private AdvWorksDbContext DbContext { get; set; }

        public User Login(UserLogin login)
        {
            var ret = DbContext.Users.Where(u => (u.Username == login.Username && u.Password == login.Password)).FirstOrDefault();

            return ret;
        }

        public User Get(int userId)
        {
            var ret = DbContext.Users.Where(u => (u.Id == userId)).FirstOrDefault();

            return ret;
        }
    }
}