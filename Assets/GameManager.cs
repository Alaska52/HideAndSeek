using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SeekerBehaviour seeker;
    public HiderBehaviour hider;

    public InfluenceMap influenceMapA;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        influenceMapA.OnUpdate();
        // 1. Calculate influence maps for hider and seeker


        // - Hider
        //    - Calculate map for safe points (not in seeker fov)
        //    - Calculate map for where seeker was in the map

        // - Seeker
        //   - Calculate areas where it has not visited before



        // 1. Determine the best point for the seeker
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(Vector3.one, Vector3.one);
    }
}
