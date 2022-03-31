using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrangeWorld.Events.EventFilters
{
    //* Base component used on event with filter parameters
    //* T = EventFilterData
    //* T2 = EventFilterArgs
    public class AEventFilterComponent : AEventComponent<EventFilterData, EventFilterArgs>{}
}