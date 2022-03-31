using UnityEngine;

namespace StrangeWorld.Events.EventFilters.Colliders
{
    //* Component used to notify collision enter call back
    public class CollisionEnterComponent : ACollisionComponent
    {
       //Notify collision enter callback
       void OnCollisionEnter(Collision collision)
       {
           InvokeEvent(this, new EventFilterArgs(Data, collision.gameObject));
           InvokeColliderEvent(this, new ColliderCallbackArgs<Collision>(collision, EColliderCallback.Enter));
       }
    }
}