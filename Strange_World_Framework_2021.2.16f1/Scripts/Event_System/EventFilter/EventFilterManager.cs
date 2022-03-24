using StrangeWorld.Core;
using UnityEngine;

namespace StrangeWorld.Events.EventFilters
{
    //* Manager used to collect all the game event listener components
    //* T = GameEventListenerComponent
    //* T2 = GameEventListenerData
    [CreateAssetMenu(fileName = "New_Event_Filter_Manager", menuName = "SW/Managers/Event_Filter_Manager")]
    public class EventFilterManager : AManager<AEventFilterComponent, EventFilterData> {}
}
