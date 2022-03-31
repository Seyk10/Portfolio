using System;
using UnityEngine;
using StrangeWorld.Core;

namespace StrangeWorld.Entities
{
    //* Data used to store scriptable enums associated to entities
    [Serializable]
    public class ScriptableEnumData : AData
    {
       [SerializeField] private ScriptableEnum scriptableEnum = null;

        public ScriptableEnum ScriptableEnum { get => scriptableEnum; }
    }
}