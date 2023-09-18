using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Variable refelcting the speed of the object
    public float speed = 1f;

    //return the speed of the object
    public float GetSpeed()
    {
        return speed;
    }
}
