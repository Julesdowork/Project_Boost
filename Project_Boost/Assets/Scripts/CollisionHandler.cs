using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Collided with Friendly object");
                break;
            case "Finish":
                Debug.Log("Collided with Landing Pad");
                break;
            default:
                Debug.Log("Collided with obstacle");
                break;
        }
    }
}
