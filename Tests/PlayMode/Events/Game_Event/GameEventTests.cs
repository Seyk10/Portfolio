using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using StrangeWorld.Events.GameEvents;

namespace StrangeWorld.Tests.Events.GameEvents
{
    //* Class used to test game event functionalities
    public class GameEventTests
    {

        //Load and invoke game event to see if the process is working
        [UnityTest]
        public IEnumerator TestGameEventListenerRespond()
        {
            //Variables
            GameEvent gameEvent = ScriptableObject.CreateInstance<GameEvent>();
            GameObject entity = new GameObject("Entity");           
            GameEventListenerComponent gameEventListenerComponent = entity.AddComponent<GameEventListenerComponent>();
            bool hasRespondGameEvent = false;                

            //Set false data and force subscription
            void SetFalseData()
            {
                gameEvent.AddSubject(gameEventListenerComponent);
                //Create one data instance and add action
                GameEventListenerData singleData = new GameEventListenerData();
                singleData.actionEventResponse = () => hasRespondGameEvent = true;
                //Add to data array single data instance
                gameEventListenerComponent.Data = new GameEventListenerData[] {singleData};
            }
            //Execute code
            SetFalseData();

            //Check if has respond to game event
            void ForceGameEvent()
            {
                gameEvent.RaiseSubjects();
                gameEvent.RemoveSubject(gameEventListenerComponent);
                Assert.IsTrue(hasRespondGameEvent);
            }
            //Execute code
            ForceGameEvent();

            //Clean instances
            MonoBehaviour.Destroy(gameEvent);
            MonoBehaviour.Destroy(entity);

            yield return null;
        }
    }
}