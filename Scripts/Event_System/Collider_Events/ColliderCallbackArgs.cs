using System;

namespace StrangeWorld.Events.EventFilters.Colliders
{
    //* Args used on collider related events
    public class ColliderCallbackArgs<T> : EventArgs
    {
        //Variables
        public readonly T callbackData = default;
        public readonly EColliderCallback eColliderCallback = default;

        //Builder
        public ColliderCallbackArgs(T callbackData, EColliderCallback eColliderCallback)
        {
            this.callbackData = callbackData;
            this.eColliderCallback = eColliderCallback;;
        }
    }
}