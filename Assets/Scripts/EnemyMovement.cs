using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour {

	private Transform target;
	private int wavePointIndex = 0;
	private Enemy enemy;
    private NavMeshAgent navMeshAgent;

    void Start()
	{
		enemy = GetComponent<Enemy> ();
		target = Waypoints.points [0];
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();

    }

	void Update ()
	{
		//Debug.Log ("Target: " + target.ToString ());
		//Debug.Log ("Transform: " + transform.ToString ());
		//Vector3 dir = target.position - transform.position;
        //transform.Translate (dir.normalized * enemy.speed * Time.deltaTime, Space.World);
        navMeshAgent.SetDestination(target.position);

		if (Vector3.Distance (transform.position, target.position) <= 0.5f)
		{
			GetNextWayPoint ();
		}

		enemy.speed = enemy.startSpeed;
	}

	void GetNextWayPoint()
	{
        Debug.Log("Getting next waypoint"); 
		if(wavePointIndex >= Waypoints.points.Length -1)
		{
			EndPath ();
			return;
		}
		wavePointIndex++;
		target = Waypoints.points [wavePointIndex];
        //
	}

	void EndPath() 
	{
		PlayerStats.Lives -= 1;
		Destroy (gameObject);

		WaveSpawner.EnemiesAlive--;
	}
}
