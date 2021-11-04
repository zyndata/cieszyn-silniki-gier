using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public TextMeshProUGUI pickupCountMesh;

    private int pickupFoundCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter " + other.gameObject.name);
        PickupObject pickup = other.gameObject.GetComponent<PickupObject>();
        if (pickup != null)
        {
            pickup.OnPickupFound();
            pickupFoundCount++;

            pickupCountMesh.text = pickupFoundCount.ToString();
        }

    }

}
