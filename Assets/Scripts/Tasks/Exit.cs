using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "key") {
            this.gameObject.SetActive(false);
        }
    }
}
