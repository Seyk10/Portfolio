using UnityEngine;

namespace StrangeWorld.Events.EventFilters.Colliders
{
    //* Component to notify trigger exit call backs
    public class TriggerExitComponent : ATriggerComponent
    {
        //Notify trigger enter callbacks
        void OnTriggerExit(Collider other)
        {
            InvokeEvent(this, new EventFilterArgs(Data, other.gameObject));
            InvokeColliderEvent(this, new ColliderCallbackArgs<Collider>(other, EColliderCallback.Exit));
        }
    }
}