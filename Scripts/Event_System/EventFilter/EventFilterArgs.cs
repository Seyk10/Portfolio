using UnityEngine;
using StrangeWorld.Core;

namespace StrangeWorld.Events.EventFilters
{
    //* Args used to share events with filters
    //* T = EventFilterData
    public class EventFilterArgs : DataArgs<EventFilterData>
    {
        //Variables
        public readonly GameObject entity = null;

        //Builder
        public EventFilterArgs(EventFilterData[] data, GameObject entity) : base(data) => this.entity = entity;       
    }
}