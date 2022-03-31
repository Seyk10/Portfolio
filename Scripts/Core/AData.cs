using System;
using UnityEngine;

namespace StrangeWorld.Core
{
    //*Abstract class used as base of data type classes
    [Serializable]
    public abstract class AData 
    {
        //Editor variables
        [Tooltip("Data name association")]
        [TextArea(3,7)]
        #pragma warning disable 0414
        [SerializeField] private string dataName = null;
        [TextArea(3,7)]
        [SerializeField] private string dataDescription = null;
        #pragma warning disable 0414
    }
}