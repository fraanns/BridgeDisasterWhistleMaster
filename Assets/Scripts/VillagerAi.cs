using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VillagerAi : MonoBehaviour
{
    Transform player;

    NavMeshAgent agent;

    Animator anim;

    public TMPro.TMP_Text headText;

    bool atGoal = false;

    public bool dead = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        anim = GetComponent<Animator>();

        player = GameObject.FindGameObjectWithTag("Player").transform;

        headText.text = "";
    }

    private void Update()
    {
        if (agent != null && agent.enabled)
        {
            anim.SetBool("run", agent.velocity.magnitude > 0.2f);

            if (!agent.pathPending)
            {
                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                    {
                        // Done

                        atGoal = true;
                    }
                }
            }

            if (!atGoal)
            {
                agent.SetDestination(player.position);
            }
        }
       

       

    }

    public void Follow()
    {
        agent.SetDestination(player.position);
        headText.text = "";
        atGoal = false;
    }

   

    void Die()
    {
        
    }

    public void Prime()
    {
        headText.text = "!";
    }
}
