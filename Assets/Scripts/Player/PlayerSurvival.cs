using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerSurvival : MonoBehaviour
{
    public GameObject player;
    public GameObject ghost;
    public MeshRenderer deathtext;
    public MeshRenderer deathbackground;
    public Vector3 respawn;
    public Vector3 ghostreset;
 
    void Start()
    {
        gameObject.tag = "NotHidden";
        ghost = GameObject.FindGameObjectWithTag("Ghost");
        deathtext.enabled = false;
        deathbackground.enabled = false;
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
            deathtext.enabled = true;
            deathbackground.enabled = true;
        }
    }
 
}
