using StrangeWorld.Core;
using UnityEngine;

namespace StrangeWorld.Events.GameEvents
{
    //* Manager used to collect all the game event listener components
    //* T = GameEventListenerComponent
    //* T2 = GameEventListenerData
    [CreateAssetMenu(fileName = "New_Game_Event_Listener_Manager", menuName = "SW/Managers/Game_Event_Manager")]
    public class GameEventManager : AManager<GameEventListenerComponent, GameEventListenerData> { }
}
