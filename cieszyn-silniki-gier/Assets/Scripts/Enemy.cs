using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public Animator animator;
    public Transform player;
    public float randomRange = 10.0f;
    public bool isAlive = true;
    private float timer;
    public bool isAttacking = false;



    private void Update()
    {

        if (Vector3.Distance(transform.position, player.position) < 5.0f)
        {
            navAgent.SetDestination(player.position);
            if (navAgent.remainingDistance <= navAgent.stoppingDistance && isAttacking == false)
            {
                isAttacking = true;
                animator.Play("Attack");
            }
        }
        else
        {
            timer += Time.deltaTime;
            if (timer > 10.0f)
            {
                timer = 0.0f;
                RandomWalk();
            }
        }

        if (isAttacking == false)
        {

            if (navAgent.remainingDistance > navAgent.stoppingDistance)
            {
                animator.Play("walk");
            }
            else
            {
                animator.Play("idle");
            }
        }

    }

    public void Kill()
    {
        //TODO better kill , animation, particle, etc
        isAlive = false;
        Destroy(gameObject);
    }

    //animator event call
    public void OnAttackEnd()
    {
        isAttacking = false;
    }


    private void RandomWalk()
    {
        Vector3 randomPoint = transform.position + Random.insideUnitSphere * randomRange;
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, randomRange, NavMesh.AllAreas))
        {
            Vector3 result = hit.position;
            navAgent.SetDestination(result);
            Debug.DrawLine(transform.position, result, Color.green, 3.0f);
        }
    }

}

