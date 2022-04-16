using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Disable this class before publishing!
public class DebugKeys : MonoBehaviour
{
    CollisionHandler collisionHandler;

    void Awake()
    {
        collisionHandler = FindObjectOfType<CollisionHandler>();
    }

    void Update()
    {
        RespondToDebugKeys();
    }

    private void RespondToDebugKeys()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            collisionHandler.LoadNextLevel();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            collisionHandler.ToggleCollision();
        }
    }
}
