using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CrashDetector : MonoBehaviour
{
    // using the inspector let the user choose particle effect, then play it when the player crashes

    [SerializeField] private ParticleSystem particleEffect;
    [SerializeField] private string tagToCheck = "Ground";
    [SerializeField] private float secondsToWait = 1f;

    // Turn on game object when crash detected
    public TextMeshProUGUI textToDisplay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagToCheck)
        {
            Debug.Log("Crash");
            ShowCrashMessage("Crash");
            particleEffect.Play();
            StartCoroutine(HideCrashMessage(secondsToWait));
            StartCoroutine(RestartLevel(secondsToWait));
        }
    }

    // Enable the TextMeshPro object with a crash message
    void ShowCrashMessage(string message)
    {
        textToDisplay.text = message; // Corrected from crashText to textToDisplay
        textToDisplay.gameObject.SetActive(true); // Corrected from crashText to textToDisplay
    }

    // Disable the TextMeshPro object after a delay
    IEnumerator HideCrashMessage(float delay)
    {
        yield return new WaitForSeconds(delay);
        textToDisplay.gameObject.SetActive(false); // Corrected from crashText to textToDisplay
    }

    IEnumerator RestartLevel(float secondsToWait = 1)
    {
        yield return new WaitForSeconds(secondsToWait);
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
