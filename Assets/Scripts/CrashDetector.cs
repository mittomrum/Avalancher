using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{ 
    //This script it attached to the level, it should detect and handle the crash of the player, if the player is crashing with his circle collider trigger, I would like to print out in the debug log "Crash" and then restart the level.
    //I would like to use the OnTriggerEnter2D function to detect the crash, and then use the SceneManager to restart the level.


 // the collider is a circle collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Crash");
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}