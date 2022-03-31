using UnityEngine;

namespace StrangeWorld.Events.EventFilters.Colliders
{
    //* Base class for trigger event components
    public class ATriggerComponent : AColliderComponent<Collider>
    {
        //Get collider and set config
        protected void Start() => GetComponent<Collider>().isTrigger = true;
    }
}