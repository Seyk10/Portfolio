using StrangeWorld.Core;
using StrangeWorld.Entities;
using UnityEngine;

namespace StrangeWorld.Events.EventFilters
{
    //* Profile used to share event filter configuration
    [CreateAssetMenu(fileName = "New_Event_Filter_Profile", menuName = "SW/Profiles/Event_Filter")]
    public class EventFilterProfile : AProfile
    {
        [SerializeField] private int[] layers = null;
        [SerializeField] private string[] tags = null;
        [SerializeField] private ScriptableEnum[] scriptableEnums = null;

        public int[] Layers { get => layers; }
        public string[] Tags { get => tags; }
        public ScriptableEnum[] ScriptableEnums { get => scriptableEnums; }
    }
}