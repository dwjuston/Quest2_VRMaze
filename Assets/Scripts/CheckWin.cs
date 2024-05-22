using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    public GameObject winMessage;

    // Start
    void Start()
    {
        // Set the winMessage to be inactive
        winMessage.SetActive(false);
    }


    // OnTriggerEnter is called when the Collider other enters the trigger.
    void OnTriggerEnter(Collider other)
    {
        // Compare and check if "MainCamera" is the object that entered the trigger
        if (other.gameObject.CompareTag("MainCamera"))
        {
           winMessage.SetActive(true);
        }
    }
}
