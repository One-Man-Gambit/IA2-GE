using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;
    int score = 0;
    int coinsCollected;
    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void coinCollect(int coinValue)
    {
        score += coinValue;
        coinsCollected += 1;
        Debug.Log("Coins picked up: " + coinsCollected);
        Debug.Log("Score: " + score);
    }
}
