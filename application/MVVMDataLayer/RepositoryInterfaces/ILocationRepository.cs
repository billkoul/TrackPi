using System.Collections.Generic;
using MVVMEntityLayer;

namespace MVVMDataLayer
{
    public interface ILocationRepository
    {
        List<Location> Get(int devId);

        List<Location> GetMany(List<int> devIds);

        Location GetLast(int devId);
    }
}