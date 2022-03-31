using StrangeWorld.Entities;
using UnityEngine;

namespace StrangeWorld.Patrons
{
    //*Static class used to manage singleton instance
    public abstract class AMonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        //Variables
        //Static internal reference of singleton
        private static T instance = default;

        //Get singleton reference and create instance if it doesn't exist'
        public static T Instance
        {
            //Manage singleton reference
            get
            {
                //Set singleton
                if (instance == null)                    
                    instance = new InstantiateEntityAndComponentCommand<T>(typeof(T).FullName).Execute().GetComponent<T>();

                return instance;
            }
        }

        //MonoBehaviour
        //Avoid duplicate singletons
        void Awake()
        {
            bool correctSingleton = instance != null && instance == this;

            if(!correctSingleton) Destroy(gameObject);
        }

        //Remove singleton reference
        void OnDestroy()
        {
            bool correctSingleton = instance != null && instance == this;

            if (correctSingleton) instance = null;
        }
    }
}