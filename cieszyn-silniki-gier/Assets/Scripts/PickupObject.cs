using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public AudioSource pickupSound;
    public GameObject pickupModel;
    public ParticleSystem collectParticles;
    public float rotationSpeed = 200.0f;

    private bool isFound = false;


    void Update()
    {
        transform.Rotate(0.0f, rotationSpeed * Time.deltaTime, 0.0f);
    }

    public void OnPickupFound()
    {
        if (isFound == false)
        {
            isFound = true;
            pickupModel.SetActive(false);
            pickupSound.Play();
            collectParticles.Play();
        }
    }
}
