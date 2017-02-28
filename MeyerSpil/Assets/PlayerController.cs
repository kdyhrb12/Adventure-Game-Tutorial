using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float m_Speed = 20f;

    private Vector3 moveTo;
    private Vector3 up = new Vector3(0, 4.5f, 0);
    private Vector3 down = new Vector3(0, 3, 0);

    public void ToggleRotationDirection()
    {
        Debug.Log("Moving cup");

        if (moveTo == up)
        {
            moveTo = down;
        }
        else
        {
            moveTo = up;
        }

        transform.position = moveTo;
    }

    void Update()
    {
        
    }
}