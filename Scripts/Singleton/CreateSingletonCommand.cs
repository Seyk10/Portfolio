using StrangeWorld.Patrons.Commands;
using StrangeWorld.Tools;
using UnityEngine;

namespace StrangeWorld.Patrons
{
    //* Command used to make a safe save of singleton reference
    //* T = Singleton type
    public class CreateSingletonCommand<T> : ICommandReturn<T>
    {
        //Variables
        //Store singleton values to use
        private readonly T singletonReference;
        private readonly T newReference;

        //Builder
        //Used to get target references
        public CreateSingletonCommand(T singletonReference, T newReference)
        {
            this.singletonReference = singletonReference;
            this.newReference = newReference;
        }

        //Execute command content
        public T Execute()
        {
            //Reference to return
            T returnValue = default;

            //Create singleton or destroy gameObject instance
            if (SingletonTools.CanSetInstance(singletonReference, newReference)) returnValue = newReference;
            else
            {
                //Return same singleton value
                returnValue = singletonReference;
                //Check if references are equal
                if (singletonReference.Equals(newReference)) SingletonTools.DebugDuplicateSingleton();
                else if(singletonReference == null) Debug.LogWarning("Singleton reference inst empty.");
                else if(newReference == null) ReferencesTools.DebugMissingReference();
            }

            return returnValue;
        }
    }
}