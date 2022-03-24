using UnityEngine;
using System.Collections.Generic;
using StrangeWorld.Patrons.Observer;
using StrangeWorld.Collections;

namespace StrangeWorld.Events.GameEvents
{
    //* Scriptable object used to raise events around a group of listeners
    [CreateAssetMenu(fileName = "New_Game_Event", menuName = "SW/Patrons/Game_Event")]
    public class GameEvent : ScriptableObject, IObserver
    {
        //Variables
        //Store subjects
        private readonly List<ISubject> listeners = new();

        //Add a new listener
        public void AddSubject(ISubject subject) => CollectionsTools.SafeListAdd(listeners, subject);

        //Notify to all the listeners when game event
        public void RaiseSubjects()
        {
            //Itinerate listeners and raise responds
            foreach (ISubject subject in CollectionsTools.GetAuxiliaryList(listeners))
                subject.Respond();
        }

        //Remove a listener
        public void RemoveSubject(ISubject subject) => CollectionsTools.SafeListRemove(listeners, subject);
    }
}