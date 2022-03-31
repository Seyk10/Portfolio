using System.Collections.Generic;
using StrangeWorld.Tools;

namespace StrangeWorld.Collections
{
    //*Tool class used to generic collection solutions
    public static class CollectionsTools
    {
        //Methods
        //Safe object add to list
        public static bool SafeListAdd<T>(List<T> collection, T value)
        {
            //Return if could add
            bool added = false;

            //Check reference
            if (collection != null)
                //Check if collection doesn't contain value
                if (!collection.Contains(value))
                {
                    collection.Add(value);
                    added = true;
                }
            //Debug error
            else ReferencesTools.DebugMissingReference();

            return added;
        }

        //Safe object remove from list
        public static bool SafeListRemove<T>(List<T> collection, T value)
        {
            //Return if could remove
            bool removed = false;           

            //Check reference
            if (collection != null)
                //Check if collection contain value
                if (collection.Contains(value))
                {
                    collection.Remove(value);
                    removed = true;
                }
            //Debug error
            else ReferencesTools.DebugMissingReference();

            return removed;
        }

        //Generate auxiliary list to avoid errors iterations
        public static List<T> GetAuxiliaryList<T>(List<T> list)
        {
            //Return list
            List<T> auxiliaryList = new List<T>();

            //Check reference inst empty
            if (list != null)
                //Itinerate and copy the list
                foreach (T item in list)
                    SafeListAdd(auxiliaryList, item);
            else ReferencesTools.DebugMissingReference();

            return auxiliaryList;
        }

        //Check if a element is inside of given array
        public static bool HasArrayObject<T>(T[] array, T value)
        {
            bool returnValue = false;

            //Check array inst null
            if (array != null)
                //Itinerate array
                foreach (T item in array)
                { if (item.Equals(value)) returnValue = true; }
            else
                ReferencesTools.DebugMissingReference();

            return returnValue;
        }
    }
}