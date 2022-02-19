using System;
using System.Collections.Generic;
using System.Linq;
using MVVMDataLayer;
using MVVMEntityLayer;

namespace MVVMViewModelLayer
{
    public class DeviceViewModel : ViewModelBase
    {
        /// <summary>
        /// NOTE: You need a parameterless     
        /// constructor for post-backs in MVC    
        /// </summary>
        public DeviceViewModel() : base()
        {
            subId = 0;
        }

        public DeviceViewModel(IDeviceRepository repository) : base()
        {
            Repository = repository;
            subId = 0;
        }

        public IDeviceRepository Repository { get; set; }
        public List<Device> Devices { get; set; }
        public int subId { get; set; }

        public override void HandleRequest()
        {
            GetDevices();
        }

        protected virtual void GetDevices()
        {
            if (Repository == null)
            {
                throw new ApplicationException("Must set the Repository property.");
            }
            else
            {
                Devices = Repository.Get(subId).ToList();
            }
        }
    }
}