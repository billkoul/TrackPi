using System;
using System.Collections.Generic;
using System.Linq;
using MVVMDataLayer;
using MVVMEntityLayer;

namespace MVVMViewModelLayer
{
    public class UserViewModel : ViewModelBase
    {
        /// <summary>
        /// NOTE: You need a parameterless     
        /// constructor for post-backs in MVC    
        /// </summary>
        public UserViewModel() : base()
        {
            UserLogin = new UserLogin();
        }

        public UserViewModel(IUserRepository repository) : base()
        {
            Repository = repository;
            UserLogin = new UserLogin();
        }

        public IUserRepository Repository { get; set; }
        public User User { get; set; }

        public UserLogin UserLogin { get; set; }
        public int UserId { get; set; }

        public override void HandleRequest()
        {
            switch (EventCommand.ToLower())
            {
                case "current":
                    Get();
                    break;
                default:
                    Login();
                    break;
            }
        }

        public virtual void Get()
        {
            if (Repository == null)
            {
                throw new ApplicationException("Must set the Repository property.");
            }
            else
            {
                User = Repository.Get(UserId);
            }
        }

        public virtual void Login()
        {
            if (Repository == null)
            {
                throw new ApplicationException("Must set the Repository property.");
            }
            else
            {
                User = Repository.Login(UserLogin);
            }
        }
    }
}