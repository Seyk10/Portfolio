using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace StrangeWorld.MemoryManagement
{
    //* Class used to store references on assets loaded and their operations
    public class ScriptableAddressablesReference
    {
        //Store loaded assets
        public readonly List<AssetReference> loadedAssets = new();
        //Store assets that are loading
        public readonly List<AssetReference> queuedAssets = new();
        //Store results of loading operations
        public readonly Dictionary<AssetReference, AsyncOperationHandle<ScriptableObject>> asyncOperationHandles = new();
    }
}
