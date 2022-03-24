using StrangeWorld.Collections;
using UnityEngine;

namespace StrangeWorld.Core
{
    //* Base class of all data managers, manage runtime sets and events related
    //* T = Component type
    //* T2 = Data type
    public abstract class AManager<T, T2> : ScriptableObject,
        IComponentAwakeResponsive<T2>, IComponentDestroyResponsive<T2>, IComponentDisableResponsive<T2>, IComponentEnableResponsive<T2>
        where T : AComponent<T2> where T2 : AData
    {
        //Used to store all the components of target type on scene
        public static ResponsiveList<T> instancesList = new(),
        enableInstancesList = new(),
        disableInstancesList = new();

        //ScriptableObject
        //Add subscriptions to component target type
        void OnEnable()
        {
            AComponent<T2>.AwakeEvent += OnComponentAwakeResponse;
            AComponent<T2>.DestroyEvent += OnComponentDestroyResponse;
            AComponent<T2>.EnableEvent += OnComponentEnableResponse;
            AComponent<T2>.DisableEvent += OnComponentDisableResponse;
        }

        //Remove subscriptions to component target type
        void OnDisable()
        {
            AComponent<T2>.AwakeEvent -= OnComponentAwakeResponse;
            AComponent<T2>.DestroyEvent -= OnComponentDestroyResponse;
            AComponent<T2>.EnableEvent -= OnComponentEnableResponse;
            AComponent<T2>.DisableEvent -= OnComponentDisableResponse;
        }

        //Respond to component awake event, add component to list
        public void OnComponentAwakeResponse(AComponent<T2> component) => instancesList.AddElement((T)component);

        //Respond to component destroy event, add component to list
        public void OnComponentDestroyResponse(AComponent<T2> component) => instancesList.RemoveElement((T)component);

        //Respond to component disable event, add component to list
        public void OnComponentDisableResponse(AComponent<T2> component)
        {
            //Convert component
            T value = (T)component;

            disableInstancesList.AddElement(value);
            //Remove if list has the element
            if (enableInstancesList.ContainsElement(value))
                enableInstancesList.RemoveElement(value);
        }

        //Respond to component enable event, add component to list
        public void OnComponentEnableResponse(AComponent<T2> component)
        {
            //Convert component
            T value = (T)component;

            enableInstancesList.AddElement(value);
            //Remove if list has the element
            if (disableInstancesList.ContainsElement(value))
                disableInstancesList.RemoveElement(value);
        }
    }
}