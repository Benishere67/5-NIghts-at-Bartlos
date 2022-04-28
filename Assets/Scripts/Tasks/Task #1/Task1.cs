using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public static bool taskDone;

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "trashcan") {
            taskDone = true;
            this.gameObject.SetActive(false);
            Debug.Log("cube in da can");
        }
    }
}
