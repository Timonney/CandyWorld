using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ennemy : MonoBehaviour
{
    NavMeshAgent agent;

    private void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(EndManager.endPosition);
    }

    public void DestroyEnnemy()
    {
        agent.enabled = false;
        Destroy(this.gameObject);
    }
}
