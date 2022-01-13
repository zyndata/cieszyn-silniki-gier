using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationController : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public Camera mainCamera;
    public LayerMask hitLayer;
    public Animator animator;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            bool hitSuccess = Physics.Raycast(ray, out hit, 100.0f, hitLayer);

            if (hitSuccess == true)
            {
                Debug.Log("Hit success: " + hit.collider.gameObject.name);
                navAgent.SetDestination(hit.point);
            }

        }


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
