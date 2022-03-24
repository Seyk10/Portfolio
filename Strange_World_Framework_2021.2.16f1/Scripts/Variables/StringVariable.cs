using UnityEngine;

namespace StrangeWorld.Variables
{
    //* Asset type string variable
    [CreateAssetMenu(fileName = "New_String_Variable", menuName = "SW/Variables/String")]
    public class StringVariable : AVariable<string> { }
}