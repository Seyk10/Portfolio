using System;
using UnityEngine;

namespace StrangeWorld.Events.EventFilters
{
    //* Data structure used on event filter base components
    [Serializable]
    public class EventFilterData : EventData
    {
        [SerializeField] private EventFilterProfile profile = null;
        [SerializeField] private GameObject[] entities = null;

        public GameObject[] Entities { get => entities; }
        public EventFilterProfile Profile { get => profile; }
    }
}