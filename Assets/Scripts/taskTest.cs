using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskTest : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Object") {
            Debug.Log("Task Completed");
        }
    }
}
