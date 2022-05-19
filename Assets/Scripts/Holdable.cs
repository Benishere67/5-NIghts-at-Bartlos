using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holdable : MonoBehaviour
{
    public Transform Bucket;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "top") {
            this.gameObject.transform.SetParent(Bucket);
        }
    }
}
