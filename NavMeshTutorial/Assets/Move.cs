using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour {
    public Transform waypoint1;
    public Transform waypoint2;
    public Transform waypoint3;
    NavMeshAgent agent;

    private bool visited1;
    private bool visited2;
    private bool visited3;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(0,1,-10);
        agent = GetComponent<NavMeshAgent>();

        visited1 = true;
        visited2 = false;
        visited3 = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (!visited1)
        {
            // visit waypoint1's position
            agent.SetDestination(waypoint1.position);

            if (waypoint1.position.x == agent.transform.position.x && waypoint1.position.z == agent.transform.position.z)
            {
                visited1 = true;
                visited2 = false;
                visited3 = true;
            }
        }
        if (!visited2)
        {
            // visit waypoint2's position
            agent.SetDestination(waypoint2.position);

            if (waypoint2.position.x == agent.transform.position.x && waypoint2.position.z == agent.transform.position.z)
            {
                visited1 = true;
                visited2 = true;
                visited3 = false;
            }
        }
        if (!visited3)
        {
            // visit waypoint2's position
            agent.SetDestination(waypoint3.position);

            if (waypoint3.position.x == agent.transform.position.x && waypoint3.position.z == agent.transform.position.z)
            {
                visited1 = false;
                visited2 = true;
                visited3 = true;
            }
        }
    }
}
