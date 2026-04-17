using UnityEngine;
using UnityEngine.AI;

public class SeekerBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    public Vector3 destinationToGO;

    public void Move(Vector3 destination)
    {
        destinationToGO = destination;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (agent == null)
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destinationToGO;
    }

    public bool AtDestination(NavMeshAgent agent)
    {
        // 1. Check if the path is still being calculated
        if (!agent.pathPending)
        {
            // 2. Check if the distance to target is within the stopping threshold
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                // 3. Confirm the agent has no further path or has stopped moving
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
