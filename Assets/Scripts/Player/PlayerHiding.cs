using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHiding : MonoBehaviour
{
    void Start()
    {
        gameObject.tag = "NotHidden";
        Debug.Log("Player is out in the open");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HidingSpace") {
            gameObject.tag = "Hidden";
            Debug.Log("Player hid");
        }
    }

    void OnTriggerExit(Collider other)
    {
        gameObject.tag = "NotHidden";
    }
}
