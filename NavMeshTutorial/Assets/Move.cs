using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour {

    public List<Transform> Waypoints;

    private NavMeshAgent agent;
    private Transform currentWaypoint;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        SetNewDestinaton();
	}

    // Update is called once per frame
    void Update()
    {
        if ((transform.position - currentWaypoint.position).magnitude <= 1)
        {
            Debug.Log("New Waypoint: " + currentWaypoint.position);
            SetNewDestinaton();
        }
    }

    void SetNewDestinaton()
    {
        currentWaypoint = Waypoints[Random.Range(0, Waypoints.Count)];
        agent.SetDestination(currentWaypoint.position);
    }
}
