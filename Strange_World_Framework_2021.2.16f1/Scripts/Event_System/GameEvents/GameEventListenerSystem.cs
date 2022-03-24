using UnityEngine;
using StrangeWorld.Core;

namespace StrangeWorld.Events.GameEvents
{
    //*System used to manage game event listeners
    //* T = GameEventListenerComponent
    //* T2 = GameEventListenerData
    //* T3 = DataArgs<GameEventListenerData>
    [CreateAssetMenu(fileName = "New_Game_Event_Listener_System", menuName = "SW/Systems/Game_Event_System")]
    public class GameEventListenerSystem : AEventSystem<GameEventListenerComponent, GameEventListenerData, DataArgs<GameEventListenerData>>
    { 
        //GetComponent and subscribe to event raise on component eneable event
        public override void OnComponentEnableResponse(AComponent<GameEventListenerData> component)
        {
            //Execute base
            base.OnComponentEnableResponse(component);

            //Itinerate and subscribe to data game events
            GameEventListenerComponent gameEventListenerComponent = component.GetComponent<GameEventListenerComponent>();

            //Avoid missing references
            if (gameEventListenerComponent.Data != null)
                foreach (var dataElement in gameEventListenerComponent.Data)
                {
                    //Avoid missing references
                    if (dataElement.GameEventReference != null)
                        dataElement.GameEventReference.AddSubject(gameEventListenerComponent);
                }
        }

        //GetComponent and unsubscribe to event raise on component disable event
        public override void OnComponentDisableResponse(AComponent<GameEventListenerData> component)
        {
            //Execute base
            base.OnComponentDisableResponse(component);

            //Itinerate and unsubscribe to data game events
            GameEventListenerComponent gameEventListenerComponent = component.GetComponent<GameEventListenerComponent>();

            //Avoid missing references
            if (gameEventListenerComponent.Data != null)
                foreach (var dataElement in gameEventListenerComponent.Data)
                {
                    //Avoid missing references
                    if (dataElement.GameEventReference != null)
                        dataElement.GameEventReference.RemoveSubject(gameEventListenerComponent);
                }
        }
    }
}