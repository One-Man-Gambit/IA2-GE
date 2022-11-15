using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carmovement : MonoBehaviour
{
    public static Carmovement instance;

    public float carSpeed = 3.0f;
    public int turnDirection = 0;

    public bool isGasPressed = false;
    public bool isLeftPressed = false;
    public bool isRightPressed = false;

    private void Awake() 
    {
        if (instance == null) 
        {
            instance = this;
        }        
    }

    private void Update() 
    {
        if (isGasPressed) 
        {
            Vector3 direction = Vector3.zero;
            direction += transform.forward;
            direction += transform.right * turnDirection;
            
            transform.position += direction * Time.deltaTime * carSpeed;
        }
    }

    public void GasButton() 
    {
        isGasPressed = !isGasPressed;
    }

    public void LeftButtonDown() 
    {
        if (!isLeftPressed)
            turnDirection = -1;
        else 
            turnDirection = 0;  

        isLeftPressed = !isLeftPressed;
    }

    public void RightButtonDown() 
    {
        if (!isRightPressed)
            turnDirection = 1;
        else 
            turnDirection = 0;

        isRightPressed = !isRightPressed;
    }

    public void Reset() 
    {
        isRightPressed = false;
        isLeftPressed = false;
        isGasPressed = false;
    }

    public void raceFinish()
    {

        Debug.Log("Ur done");

    }
}
