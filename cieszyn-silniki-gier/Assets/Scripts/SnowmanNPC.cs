using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanNPC : MonoBehaviour
{
    public GameObject uiPanel;
    public GameObject questStarted;
    public GameObject questFinished;
    public PickupController pickupController;
    private bool isQuestFinished = false;


    private void Start()
    {
        HideUI();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) == true)
        {
            if (pickupController.GotAllPickups() == false)
            {
                questStarted.SetActive(true);
                questFinished.SetActive(false);
            }
            else
            {
                questStarted.SetActive(false);
                questFinished.SetActive(true);
            }
        }
    }

    public void ShowUI()
    {
        uiPanel.SetActive(true);
    }

    public void HideUI()
    {
        uiPanel.SetActive(false);
        questStarted.SetActive(false);
        questFinished.SetActive(false);
    }



}
