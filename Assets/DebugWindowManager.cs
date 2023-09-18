using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugWindowManager : MonoBehaviour
{
    // Shange the textmeshpro text to reflect the current speed of the player, the player should be added in the inspector, and the speed should update every frame

    [SerializeField] TextMeshProUGUI playerSpeedText;
    private Player player;

    void Awake()
    {
        if (playerSpeedText == null){
            Debug.Log("Could not find player speed text, have you forgotten to add it in the inspector? (debugwindow)");
        }
        player = FindObjectOfType<Player>();
    }
    void Update()
    {
        UpdatePlayerSpeed();
    }

    public void UpdatePlayerSpeed()
    {
        //make sure the player is not null, and the speed variable exists, otherwise change the text to undefined
        if (player == null || float.IsNaN(player.speed))
        {
            playerSpeedText.text = "Undefined";
            Debug.LogWarning("Player or speed is null");
            return;
        } 
        
            playerSpeedText.text = player.GetSpeed().ToString();
        
    }
}
