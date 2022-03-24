using System;
using UnityEngine;

namespace StrangeWorld.Events.EventFilters.Colliders
{
    //* Base component for collider related components
    //* T = collider or collision type
    [RequireComponent(typeof(Collider))]
    [RequireComponent(typeof(Rigidbody))]
    public abstract class AColliderComponent<T> : AEventFilterComponent
    {
        //Variables
        public event EventHandler<ColliderCallbackArgs<T>> ColliderCallBackEvent = null;

        //Invoke event from children
        protected void InvokeColliderEvent(object sender, ColliderCallbackArgs<T> args) => ColliderCallBackEvent?.Invoke(sender, args);
    }
}