using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent ghost;
    public GameObject player;
    
    void Start()
    {
        ghost = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.Find("Player");
        ghost.SetDestination(player.transform.position);
    }


    void Update()
    {
        ghost.SetDestination(player.transform.position);
    }
}
