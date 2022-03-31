using UnityEngine;

namespace StrangeWorld.Events.EventFilters.Colliders
{
    //* Component used to notify collision exit call backs
    public class CollisionExitComponent : ACollisionComponent
    {
        //Notify collision exit callback
        void OnCollisionExit(Collision other)
        {
            InvokeEvent(this, new EventFilterArgs(Data, other.gameObject));
           InvokeColliderEvent(this, new ColliderCallbackArgs<Collision>(other, EColliderCallback.Exit));
        }
    }
}