using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    private void QuitGame()
    {
        Debug.Log("Quitting Project Boost...");
        Application.Quit();
    }
}
