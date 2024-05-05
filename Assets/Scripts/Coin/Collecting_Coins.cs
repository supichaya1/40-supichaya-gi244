using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting_Coins : MonoBehaviour
{
    public int coins;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coins")
        {
            Debug.Log("Coins");
            coins = coins + 1;
            Col.gameObject.SetActive(false);
        }

        
    }
}
