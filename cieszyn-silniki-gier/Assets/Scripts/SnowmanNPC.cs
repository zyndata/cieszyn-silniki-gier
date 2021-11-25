using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanNPC : MonoBehaviour
{
    public GameObject uiPanel;
    public GameObject questStarted;
    public GameObject questFinished;
    public PickupController pickupController;
    public Animator doorAnimator;
    public Animator playerAnimator;
    public AudioSource doorOpenSound;
    public GameObject questCamera;
    private bool isQuestFinished = false;
    private bool isPlayerNear = false;


    private void Start()
    {
        HideUI();
    }

    private void Update()
    {
        //opcja 1
        //if(isQuestFinished == true)
        //{
        //    return;
        //}


        if (Input.GetKeyDown(KeyCode.E) == true && isPlayerNear == true)
        {
            if (pickupController.GotAllPickups() == false)
            {
                questStarted.SetActive(true);
                questFinished.SetActive(false);
            }
            else
            {
                //we have all presents
                if (isQuestFinished == false) //opcja 2
                {
                    isQuestFinished = true;
                    doorAnimator.Play("DoorOpen");
                    playerAnimator.Play("Cheering");
                    doorOpenSound.Play();
                    questStarted.SetActive(false);
                    questFinished.SetActive(true);
                }
            }
        }
    }

    public void ShowUI()
    {
        questCamera.SetActive(true);
        uiPanel.SetActive(true);
        isPlayerNear = true;
    }

    public void HideUI()
    {
        questCamera.SetActive(false);
        isPlayerNear = false;
        uiPanel.SetActive(false);
        questStarted.SetActive(false);
        questFinished.SetActive(false);
    }



}
