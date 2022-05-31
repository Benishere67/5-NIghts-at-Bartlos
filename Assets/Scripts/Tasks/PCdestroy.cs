using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCdestroy : MonoBehaviour
{
    public GameObject key;

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "metal") {
            other.gameObject.SetActive(false);
            key.SetActive(true);
        }
    }
}
