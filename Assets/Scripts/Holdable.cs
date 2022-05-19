using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holdable : MonoBehaviour
{
    public Transform Bucket;

    void OnCollsionEnter(Collision other) {
        Debug.Log("ok");
        if (other.gameObject.tag == "bucket") {
            this.gameObject.transform.SetParent(Bucket.parent);
            Debug.Log("hmmm");
        }
    }
}
