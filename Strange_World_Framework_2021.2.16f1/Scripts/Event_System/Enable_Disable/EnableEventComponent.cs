using StrangeWorld.Core;

namespace StrangeWorld.Events
{
    //* Raise event response on enable component phase
    public class EnableEventComponent : AEventComponent<EventData, DataArgs<EventData>>
    {
        //Raise response on enable state
        protected override void OnEnable()
        {
            //base AComponent execution
            base.OnEnable();
            
            InvokeEvent(this, new DataArgs<EventData>(Data));
        }
    }
}