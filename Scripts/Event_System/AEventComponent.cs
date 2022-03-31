using StrangeWorld.Core;
using System;

namespace StrangeWorld.Events
{
    //* Abstract component used as base of related event components    
    public abstract class AEventComponent<T, T2> : AComponent<T> where T : EventData where T2 : DataArgs<T>
    {
        //Events
        //Event raised inside of the component on a specific moment
        public event EventHandler<T2> EventRaise = null;

        //Methods
        //Used to raise event from children classes
        protected virtual void InvokeEvent(object sender, T2 args) => EventRaise?.Invoke(sender, args);
    }
}
