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

    public bool death;
    public float deathseconds;
 
    void Start()
    {
        gameObject.tag = "NotHidden";
        ghost = GameObject.FindGameObjectWithTag("Ghost");
        deathtext.enabled = false;
        deathbackground.enabled = false;
        death = false;
        deathseconds = 0.3f;
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

    void Death()
    {
        deathtext.enabled = true;
        deathbackground.enabled = true;
        Time.timeScale = 0.1f;
        deathseconds -= Time.deltaTime;
    }

    void Respawn ()
    {
        death = false;
        deathtext.enabled = false;
        deathbackground.enabled = false;
        Time.timeScale = 1f;
    }
 
    void Update()
    {
        if (Vector3.Distance(ghost.transform.position, player.transform.position) <= 5) {
            player.transform.position = respawn;
            ghost.transform.position = ghostreset;
            death = true;
        }

        if (death == true) {
            Death();
            if (deathseconds <= 0) {
                Respawn();
            }
        }
    }
 
}
