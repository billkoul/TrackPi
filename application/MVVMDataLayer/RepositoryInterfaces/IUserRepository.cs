using System.Collections.Generic;
using MVVMEntityLayer;

namespace MVVMDataLayer
{
    public interface IUserRepository
    {
        User Login(UserLogin login);

        User Get(int userId);
    }
}