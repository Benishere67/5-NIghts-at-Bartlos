using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerSurvival : MonoBehaviour
{
    public GameObject player;
    public GameObject ghost;
    public MeshRenderer deathscreen;
    public Vector3 respawn;
    public Vector3 ghostreset;
 
    void Start()
    {
        gameObject.tag = "NotHidden";
        ghost = GameObject.FindGameObjectWithTag("Ghost");
        deathscreen.enabled = false;
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
 
    void Update()
    {
        if (Vector3.Distance(ghost.transform.position, player.transform.position) <= 5) {
            player.transform.position = respawn;
            ghost.transform.position = ghostreset;
            //deathscreen.enabled = true;
        }
    }
 
}
