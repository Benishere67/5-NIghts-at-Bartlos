using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompDestroy : MonoBehaviour
{
    public GameObject metal;

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Screwdriver") {
            this.gameObject.SetActive(false);
            metal.SetActive(false);
        }
    }
}
