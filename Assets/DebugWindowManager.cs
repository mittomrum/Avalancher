using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DebugWindowManager : MonoBehaviour
{
    [SerializeField] private PlayerController Player;
    [SerializeField] private TextMeshProUGUI speedFloat;
    [SerializeField] private Toggle isgroundedToggle;

    [SerializeField] private Toggle isGoingDownhillToggle;
    void Awake()
    {
        #region missing references

        if(Player == null)
        {
            Debug.Log("DebugWindowManager is missing a reference to Player");
        }
        if(speedFloat == null)
        {
            Debug.Log("DebugWindowManager is missing a reference to speedFloat");
        }
        #endregion
    }
    void Update()
    {
        UpdateSpeed();
        UpdateGroundedToggle();
        UpdateDownhillToggle();
    }

    // Update is called once per frame
    void UpdateSpeed(){
        float speed = Player.GetSpeed();
        float formatedSpeed = Mathf.Round(speed * 100f) / 100f;
        speedFloat.text = formatedSpeed.ToString();
    }
    void UpdateGroundedToggle()
    {
        bool grounded = Player.IsGrounded();
        isgroundedToggle.isOn = grounded; // Set the toggle button's state based on grounded
    }
    void UpdateDownhillToggle()
    {
        bool downhill = Player.IsGoingDownhill();
        isGoingDownhillToggle.isOn = downhill; // Set the toggle button's state based on downhill
    }
    
}