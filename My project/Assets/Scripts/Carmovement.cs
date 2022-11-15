using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carmovement : MonoBehaviour
{
    public static Carmovement instance;
    public int movementspeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * movementspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * movementspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * movementspeed * Time.deltaTime);
        }
    }

    public void raceFinish()
    {

        Debug.Log("Ur done");

    }
}
