using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskTest : MonoBehaviour
{
    OnCollisionEnter(Collision other) {
        if (other.GameObject.tag == "Object") {
            Debug.Log("Task Completed");
        }
    }
}
