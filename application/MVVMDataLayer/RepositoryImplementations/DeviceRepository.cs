using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using MVVMEntityLayer;

namespace MVVMDataLayer
{
    public class DeviceRepository : IDeviceRepository
    {
        public DeviceRepository(AdvWorksDbContext context)
        {
            DbContext = context;
        }

        private AdvWorksDbContext DbContext { get; set; }

        public List<Device> Get(int subId)
        {
            var ret = DbContext.Devices.Where(x=> x.SubId == subId).ToList();

            return ret;
        }
    }
}