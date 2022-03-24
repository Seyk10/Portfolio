using StrangeWorld.Core;
using UnityEngine;

namespace StrangeWorld.Variables
{
    //* Base class used on variable types scriptable objects
    public class AVariable<T> : AProfile
    {
       //Variables       
       [SerializeField] private T value = default;

        public T Value { get => value; set => this.value = value; }
    }
}
