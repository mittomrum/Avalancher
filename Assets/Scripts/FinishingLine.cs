using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishingLine : MonoBehaviour
{
    // If the player is colliding with the finishing line, I would like to print out in the debug log "Finish" and then restart the level.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Finish");
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}

