using UnityEngine;
using StrangeWorld.Core;

namespace StrangeWorld.Events
{
    [CreateAssetMenu(fileName = "New_Generic_Event_Manager", menuName = "SW/Managers/Generic_Event_Manager")]
    //* Generic manager used to register all the AEventComponent<EventData, DataArgs<EventData>> components
    //* T = AEventComponent<EventData, DataArgs<EventData>>
    //* T2 = EventData
    public class GenericEventManager : AManager<AEventComponent<EventData, DataArgs<EventData>>, EventData> {}
}