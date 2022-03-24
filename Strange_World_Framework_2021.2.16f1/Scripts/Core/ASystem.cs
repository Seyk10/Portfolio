using UnityEngine;

namespace StrangeWorld.Core
{
    //* Base class for system type objects
    //* T = Component type
    //* T2 = Data type
    public abstract class ASystem<T, T2> : ScriptableObject, IComponentDisableResponsive<T2>, IComponentEnableResponsive<T2> where T : AComponent<T2> where T2 : AData
    {
        //ScriptableObject
        //Add subscriptions on enable state
        protected virtual void OnEnable()
        {
            //Subscribe to manager
            AManager<T, T2>.enableInstancesList.ElementAddedEvent += OnComponentEnableResponse;
            AManager<T, T2>.disableInstancesList.ElementAddedEvent += OnComponentDisableResponse;
        }

        //Remove subscriptions on disable state
        protected virtual void OnDisable()
        {
            //Unsubscribe to manager
            AManager<T, T2>.enableInstancesList.ElementAddedEvent -= OnComponentEnableResponse;
            AManager<T, T2>.disableInstancesList.ElementAddedEvent -= OnComponentDisableResponse;
        }

        //Respond when a component is added to manager disable list
        public abstract void OnComponentDisableResponse(AComponent<T2> component);

        //Respond when a component is added to manager enable list
        public abstract void OnComponentEnableResponse(AComponent<T2> component);
    }
}