using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public LayerMask shootObjectLayer;
    public LayerMask laserLayer;
    public LineRenderer laser;


    private void Start()
    {
        HideLaser();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Ray shootRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

            RaycastHit hit;
            bool hitSuccess = Physics.Raycast(shootRay, out hit, 100.0f, shootObjectLayer);

            if (hitSuccess == true)
            {
                Debug.Log("Hit : " + hit.collider.gameObject.name);
                Enemy enemyScript = hit.collider.gameObject.GetComponent<Enemy>();
                if (enemyScript != null)
                {
                    enemyScript.Kill(); //kill enemy
                }
                StartCoroutine(ShowLaserRoutine());
            }
        }


    }

    private IEnumerator ShowLaserRoutine()
    {
        DrawLaser();

        yield return new WaitForSeconds(0.3f);

        HideLaser();

    }

    private void HideLaser()
    {
        laser.SetPosition(1, new Vector3(0.0f, 0.0f, 0.0f));
    }

    private void DrawLaser()
    {
        Transform orgin = laser.transform;


        Ray shootRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;
        bool hitSuccess = Physics.Raycast(shootRay, out hit, 100.0f, laserLayer);

        if (hitSuccess == true)
        {
            laser.SetPosition(1, new Vector3(0.0f, 0.0f, hit.distance));
        }
        else
        {
            laser.SetPosition(1, new Vector3(0.0f, 0.0f, 100.0f));
        }

    }

}
