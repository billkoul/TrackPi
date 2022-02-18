using System.Collections.Generic;
using MVVMEntityLayer;

namespace MVVMDataLayer
{
    public interface ISubscriptionRepository
    {
        List<Subscription> Get();
    }
}