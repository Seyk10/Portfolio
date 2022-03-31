using UnityEngine;
using StrangeWorld.Core;
using System;
using UnityEngine.Events;

namespace StrangeWorld.Events
{
    //* Data structure used on event related components.
    [Serializable]
    public class EventData : AData
    {
        //Editor variables
        [Header("Event response")]
        [SerializeField] private UnityEvent response = null;

        //Variables
        public Action actionEventResponse = null;

        //Attributes
        public UnityEvent Response { get => response; }
    }
}
