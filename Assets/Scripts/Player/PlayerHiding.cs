using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHiding : MonoBehaviour
{
    void Start()
    {
        gameObject.tag = "NotHidden";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HidingSpace") {
            gameObject.tag = "Hidden";
        }
    }

    void OnTriggerExit(Collider other)
    {
        gameObject.tag = "NotHidden";
    }
}
