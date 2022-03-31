using StrangeWorld.Core;
using StrangeWorld.Tools;

namespace StrangeWorld.Events
{
    //* Base abstract class used on systems related to events 
    //* T = Component type
    //* T2 = Data type
    //* T3 = Args type
    public abstract class AEventSystem<T, T2, T3> : ASystem<T, T2> where T : AEventComponent<T2, T3> where T2 : EventData where T3 : DataArgs<T2>
    {
        //Methods
        //Remove subscription to AEventComponent event
        public override void OnComponentDisableResponse(AComponent<T2> component)
        { if (component.TryGetComponent(out T eventComponent)) eventComponent.EventRaise -= OnEventRaise; }

        //Add subscription to AEventComponent event
        public override void OnComponentEnableResponse(AComponent<T2> component)
        { if (component.TryGetComponent(out T eventComponent)) eventComponent.EventRaise += OnEventRaise; }        

        //Used as response of event components
        protected virtual void OnEventRaise(object sender, T3 args)
        {
            //Avoid empty data
            if (args.data != null)
                //Itinerate and invoke response
                foreach (var data in args.data)
                {
                    data.actionEventResponse?.Invoke();
                    data.Response?.Invoke();            
                }
            else ReferencesTools.DebugMissingReference();
        }
    }
}