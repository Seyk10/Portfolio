using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace StrangeWorld.Tests.Events
{
    //* Unit tests used to verify collisions detections
    public class CollisionsTests
    {
        //Variables
        

       //Test collision enter callbacks
        [UnityTest]
        public IEnumerator CollisionsTestsWithEnumeratorPasses()
        {
            //Create collision

            //Create a collision enter component
            GameObject firstEntity = new GameObject(),
            secondEntity = new GameObject();
            //Add required components
            firstEntity.AddComponent<Rigidbody>().isKinematic = true;
            firstEntity.AddComponent<Collider>();


            yield return null;
        }
    }

}