using UnityEngine;

namespace StrangeWorld.Events.EventFilters.Colliders
{
    //* Base class used on collision type components
    public class ACollisionComponent : AColliderComponent<Collision>
    {
        //Get collider and set collision mode
        protected void Start() => GetComponent<Collider>().isTrigger = false;
    }
}