using UnityEngine;
using System;

namespace StrangeWorld.Core
{
    //* Base class for components used on entities, store related data
    //* T = Data type
    public class AComponent<T> : MonoBehaviour where T : AData
    {   
        //Editor variables
        [Header("Data")]
        [SerializeField] private T[] data;

        //Gets/Sets
        public T[] Data { get => data; set => data = value; }

        //Events
        //Event used to notify when component awake
        public static event Action<AComponent<T>> AwakeEvent = null,
            //This event is used to notify system if component is last to disable
            DestroyEvent = null,
            //Event used to notify when component enable
            EnableEvent = null,
            //event used to notify when component disable
            DisableEvent = null;

        //MonoBehaviour
        //Notify component awakes
        protected virtual void Awake() => AwakeEvent?.Invoke(this);        
        //Notify component enables
        protected virtual void OnEnable() => EnableEvent?.Invoke(this);
        //Notify component disables
        protected virtual void OnDisable() => DisableEvent?.Invoke(this);
        //Notify component destroy
        protected virtual void OnDestroy() => DestroyEvent?.Invoke(this);
    }
}