using System;
using System.Collections.Generic;
using System.Linq;
using MVVMDataLayer;
using MVVMEntityLayer;

namespace MVVMViewModelLayer
{
    public class SubscriptionViewModel
    {
        /// <summary>
        /// NOTE: You need a parameterless     
        /// constructor for post-backs in MVC    
        /// </summary>
        public SubscriptionViewModel()
        { }

        public SubscriptionViewModel(ISubscriptionRepository repository)
        {
            Repository = repository;
        }

        public ISubscriptionRepository Repository { get; set; }
        public List<Subscription> Subscriptions { get; set; }

        public void HandleRequest()
        {
            GetSubscriptions();
        }

        protected virtual void GetSubscriptions()
        {
            if (Repository == null)
            {
                throw new ApplicationException("Must set the Repository property.");
            }
            else
            {
                Subscriptions = Repository.Get().ToList();
            }
        }
    }
}