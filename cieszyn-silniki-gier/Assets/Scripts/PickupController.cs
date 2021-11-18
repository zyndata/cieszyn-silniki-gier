using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public TextMeshProUGUI pickupCountMesh;
    public int pickupOnMapCount = 3;

    private int pickupFoundCount = 0;



    private void Start()
    {
        UpdatePickupText();
    }

    public bool GotAllPickups()
    {
        if (pickupFoundCount < pickupOnMapCount)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter " + other.gameObject.name);
        PickupObject pickup = other.gameObject.GetComponent<PickupObject>();
        if (pickup != null)
        {
            pickup.OnPickupFound();
            pickupFoundCount++;

            UpdatePickupText();
        }
    }

    private void UpdatePickupText()
    {
        pickupCountMesh.text = pickupFoundCount + " / " + pickupOnMapCount;
    }

}
