using UnityEngine;

namespace StrangeWorld.Tools
{
    //*Tool class used to generic reference solutions
    public static class ReferencesTools
    {
        //Methods
        //Debug missing reference
        public static void DebugMissingReference() => Debug.LogWarning("Warning: Missing reference");
    }
}
