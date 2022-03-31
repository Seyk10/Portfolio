using UnityEngine;
using StrangeWorld.Core;

namespace StrangeWorld.Events
{
    //*System used to generic event components responses
    //* T = AEventComponent<AEventData, DataArgs<AEventData>>
    //* T2 = AEventData
    //* T3 = DataArgs<AEventData>
    [CreateAssetMenu(fileName = "New_Generic_Event_System", menuName ="SW/Systems/Generic_Event_System")]
    public class GenericEventSystem : AEventSystem<AEventComponent<EventData, DataArgs<EventData>>, EventData, DataArgs<EventData>> { }
}