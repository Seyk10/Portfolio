using System.Collections;
using System.Collections.Generic;
using StrangeWorld.Core;
using UnityEngine;

namespace StrangeWorld.Events
{
    //* Raise event response on disable component phase
    public class DisableEventComponent : AEventComponent<EventData, DataArgs<EventData>>
    {
        //Raise response on disable state
        protected override void OnDisable()
        {
            //AComponent base execution
            base.OnDisable();
            
            InvokeEvent(this, new DataArgs<EventData>(Data));
        }
    }

}