using StrangeWorld.Core;
using StrangeWorld.Patrons.Observer;

namespace StrangeWorld.Events.GameEvents
{
    //* Component used to register responses on game event raise
    public class GameEventListenerComponent : AEventComponent<GameEventListenerData, DataArgs<GameEventListenerData>>, ISubject
    {   
        //Raise internal event to notify system of event
        public void Respond() => InvokeEvent(this, new DataArgs<GameEventListenerData>(Data));
    }
}