using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

enum AIState
{
    chasing,
    Idle,
    LookingForPlayer,
    Suspicious
}

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> positions = new List<GameObject>();
    public int currentPos = 0;

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        
        print(agent.pathStatus);
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance <= agent.stoppingDistance) 
        {
            agent.SetDestination(positions[currentPos].transform.position);
            currentPos++;
            if(currentPos >= positions.Count) 
            { 
                currentPos = 0; 
            }
        }
    }

    public void ChasePlayer()
    {
        agent.SetDestination(player.transform.position);
    }
}
