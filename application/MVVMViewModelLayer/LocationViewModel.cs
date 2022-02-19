using System;
using System.Collections.Generic;
using System.Linq;
using MVVMDataLayer;
using MVVMEntityLayer;

namespace MVVMViewModelLayer
{
    public class LocationViewModel : ViewModelBase
    {
        /// <summary>
        /// NOTE: You need a parameterless     
        /// constructor for post-backs in MVC    
        /// </summary>
        public LocationViewModel() : base()
        {
            devId = 0;
            devIds = new List<int>();
        }

        public LocationViewModel(ILocationRepository repository) : base()
        {
            Repository = repository;
            devId = 0;
            devIds = new List<int>();
        }

        public ILocationRepository Repository { get; set; }
        public List<Location> Locations { get; set; }
        public Location Location { get; set; }
        public int devId { get; set; }
        public List<int> devIds { get; set; }

        public override void HandleRequest()
        {
            switch (EventCommand.ToLower())
            {
                case "last":
                    GetLast();
                    break;
                case "many":
                    GetMany();
                    break;
                default:
                    LoadTrips();
                    break;
            }
        }

        protected virtual void LoadTrips()
        {
            if (Repository == null)
            {
                throw new ApplicationException("Must set the Repository property.");
            }
            else
            {
                Locations = Repository.Get(devId).OrderByDescending(p => p.Id).ToList();
            }
        }

        protected virtual void GetLast()
        {
            if (Repository == null)
            {
                throw new ApplicationException("Must set the Repository property.");
            }
            else
            {
                Location = Repository.GetLast(devId);
            }
        }

        protected virtual void GetMany()
        {
            if (Repository == null)
            {
                throw new ApplicationException("Must set the Repository property.");
            }
            else
            {
                Locations = Repository.GetMany(devIds);
            }
        }
    }
}