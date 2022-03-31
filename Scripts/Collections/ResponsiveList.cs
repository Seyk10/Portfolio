using System;
using System.Collections.Generic;

namespace StrangeWorld.Collections
{
    //* Class used to store a responsive list, raising events on each list modification
    //* T = List type
    public class ResponsiveList<T>
    {
        //Variables
        private readonly List<T> list = new();

        public T[] ListToArray => list.ToArray();

        //Events
        public event Action<T> ElementAddedEvent = null,
       ElementRemovedEvent = null,
       FirstElementAddedEvent = null,
       LastElementRemovedEvent = null;

        //Methods
        //Add element to list and notify it
        public bool AddElement(T value)
        {
            bool returnValue = CollectionsTools.SafeListAdd(list, value);            

            //Notify if its the first element
            if (returnValue)
            {
                if (list.Count == 1) FirstElementAddedEvent?.Invoke(value);
                ElementAddedEvent?.Invoke(value);
            }

            return returnValue;
        }

        //Remove element from list and notify it
        public bool RemoveElement(T value)
        {
            bool returnValue = CollectionsTools.SafeListRemove(list, value);  
            
            //Notify if its the last element
            if (returnValue)
            {
                if (list.Count == 0) LastElementRemovedEvent?.Invoke(value);
                ElementRemovedEvent?.Invoke(value);
            }

            return returnValue;
        }
    
        //Check if list contains element
        public bool ContainsElement(T value) => list.Contains(value);
    }
}