using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using MVVMEntityLayer;

namespace MVVMDataLayer
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        public SubscriptionRepository(AdvWorksDbContext context)
        {
            DbContext = context;
        }

        private AdvWorksDbContext DbContext { get; set; }

        public List<Subscription> Get()
        {
            var ret = DbContext.Subscriptions.ToList();

            return ret;
        }
    }
}