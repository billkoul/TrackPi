using System.Collections.Generic;
using MVVMEntityLayer;

namespace MVVMDataLayer
{
    public interface IDeviceRepository
    {
        List <Device> Get(int subId);
    }
}