using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent ghost;
    public GameObject playerHead;
    public GameObject player;
    
    public float ghostMode;
    
    public float wanderX;
    public float wanderZ; 
    public Vector3 wanderDestination;
    public bool wanderReset;
    
    public float lightCount;
    public bool inLight;
    
    void Start()
    {
        wanderReset = false;
        InvokeRepeating("WanderTimer", 0f, 2f);
        ghost = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        ghostMode = 0;
        player = GameObject.Find("Player");
        playerHead = GameObject.Find("HeadCollider");
        ghost.SetDestination(player.transform.position);
        lightCount = 0;
        inLight = false;
    }

    void WanderTimer()
    {
        wanderReset = false;
    }

    void Wandering()
    {
        wanderX = ghost.transform.position.x + Random.Range(-5, 5);
        wanderZ = ghost.transform.position.y + Random.Range(-5, 5);
        wanderDestination = new Vector3(wanderX, 0, wanderZ);
        ghost.SetDestination(wanderDestination); 
        wanderReset = true;
    }

    void PlayerDetection()
    {
        Collider[] hitColliders = Physics.OverlapSphere(ghost.transform.position, 15);
        for (int i = 0; i < hitColliders.Length; i++)
        {
            GameObject hitCollider = hitColliders[i].gameObject;
            if (hitCollider.CompareTag("NotHidden"))
            {
                ghostMode = 1;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flashlight") {
            inLight = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Flashlight") {
            inLight = false;
            lightCount = 0;
        }
    }

    void Update()
    {
        if (ghostMode == 0) {
            Debug.Log("Wandering");
            if (wanderReset == false) {
                Wandering();
            }
            PlayerDetection();
        } 
        else if (ghostMode == 1) {
            Debug.Log("Found the player");
            ghost.SetDestination(player.transform.position);
           
            if (playerHead.tag == "Hidden") {
                Debug.Log("Player is hiding");
                ghostMode = 0;
            }
        }

        if (inLight == true) {
            lightCount += 1;
        }
        
        if (lightCount == 500) {
            Destroy(gameObject);
        }
    }
}
