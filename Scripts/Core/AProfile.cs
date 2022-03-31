using UnityEngine;

namespace StrangeWorld.Core
{
    //* Base class for all the profile files
    public abstract class AProfile : ScriptableObject
    {
        //Editor variables
        [TextArea(3, 7)]
        #pragma warning disable 0414
        [SerializeField] private string dataDescription = null;
        #pragma warning disable 0414
    }
}