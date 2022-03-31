using UnityEngine;

namespace StrangeWorld.Events.EventFilters.Colliders
{
    //* Component to notify trigger enter call backs
    public class TriggerEnterComponent : ATriggerComponent
    {
        //Notify trigger enter callbacks
        void OnTriggerEnter(Collider other)
        {
            InvokeEvent(this, new EventFilterArgs(Data, other.gameObject));
            InvokeColliderEvent(this, new ColliderCallbackArgs<Collider>(other, EColliderCallback.Enter));
        }
    }
}