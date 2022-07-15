using System;
using System.Collections.Generic;
using System.Linq;
using MVVMEntityLayer;

namespace MVVMDataLayer
{
    public class LocationRepository : ILocationRepository
    {
        public LocationRepository(AdvWorksDbContext context)
        {
            DbContext = context;
        }

        private AdvWorksDbContext DbContext { get; set; }

        public List<Location> Get(int devId)
        {
            return DbContext.Locations.Where(x => x.DevId == devId).ToList();
        }

        public List<Location> GetMany(List<int> devIds)
        {
            return DbContext.Locations.Where(x => devIds.Contains(x.DevId)).ToList();
        }

        public Location GetLast(int devId)
        {
            return DbContext.Locations.Where(x => x.DevId == devId).OrderByDescending(x=> x.Id).FirstOrDefault();
        }
    }
}