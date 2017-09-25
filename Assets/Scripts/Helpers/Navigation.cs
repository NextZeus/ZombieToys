using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Navigation : MonoBehaviour 
{
	
	[SerializeField] Transform target;
	[SerializeField] NavMeshAgent agent;
	[SerializeField] float updateDelay = .3f;

	void Reset()
	{
		agent = GetComponent<NavMeshAgent>();

	}

	void Start()
	{
		// agent.SetDestination(target.position);
		InvokeRepeating("FollowTarget",0f,updateDelay);
	}
		
	// void Update()
	// {
	// 	agent.SetDestination(target.position);		
	// }

	void FollowTarget()
	{
		agent.SetDestination(target.position);
	}
}
