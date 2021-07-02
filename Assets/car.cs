using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class car : MonoBehaviour
{
  public float carSpeed;
  public Transform target;

  // Start is called before the first frame update
  private void Start()
  {
    NavMeshAgent navMeshAgent = GetComponent<NavMeshAgent>();
    navMeshAgent.speed = carSpeed;
    navMeshAgent.SetDestination(target.position);

  }



  // Update is called once per frame
  void Update()
  {

  }
}
