using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class CheckUnlock : MonoBehaviour
{
    public GameObject wall;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blue"))
        {
            if (wall.activeInHierarchy)
            {
                wall.SetActive(false);
            }
            
        }
    }
}
