﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowDestination : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent = null;
    public Transform destination = null;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(destination.position);
       

    }
}
