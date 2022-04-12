using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent ghost;
    public GameObject player;
    public float ghostMode;
    public float wanderX;
    public float wanderZ;
    public Vector3 wanderDestination;
    public bool wanderReset;
    
    void Start()
    {
        wanderReset = false;
        InvokeRepeating("WanderTimer", 0f, 2f);
        ghost = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        ghostMode = 0;
        player = GameObject.Find("Player");
        ghost.SetDestination(player.transform.position);
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
            if (hitCollider.CompareTag("Player"))
            {
                ghostMode = 1;
            }
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
        }
        
    }
}
