using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holdable : MonoBehaviour
{
    public Transform toolBelt;

    private bool held = false;

    void Update() {
        if (held) {
            this.gameObject.transform.position = toolBelt.position;
        }
    }

    void OnCollsionEnter(Collision other) {
        if (other.gameObject.tag == "toolBelt") {
            held = true;
        }
    }
}
