using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractController : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        SnowmanNPC npc = other.gameObject.GetComponent<SnowmanNPC>();
        if (npc != null)
        {
            npc.ShowUI();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        SnowmanNPC npc = other.gameObject.GetComponent<SnowmanNPC>();
        if (npc != null)
        {
            npc.HideUI();
        }
    }

}
