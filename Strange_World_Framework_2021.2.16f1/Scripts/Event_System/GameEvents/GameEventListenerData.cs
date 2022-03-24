using UnityEngine;
using System;

namespace StrangeWorld.Events.GameEvents
{
    //* Data used on game event listener components, store event information
    [Serializable]
    public class GameEventListenerData : EventData
    {
        //Editor variables
       [SerializeField] private GameEvent gameEventReference = null;      

       //Attributes
        public GameEvent GameEventReference { get => gameEventReference; }
    }
}