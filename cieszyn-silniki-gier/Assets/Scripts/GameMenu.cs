using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public TMP_InputField userInputField;

    public Image hpBar;
    public GameObject pauseMenu;

    private void Start()
    {
        ResumeGame();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            if (Time.timeScale == 0.0f)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }


    private void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    private void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }


    public void OnResumeClicked()
    {
        ResumeGame();
    }

    public void OnBackMenuClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }


    public void GetDamage()
    {
        //hpBar.fillAmount = hpBar.fillAmount - 0.1f;
        hpBar.fillAmount -= 0.1f;
    }

    public void GetUsername()
    {
        Debug.Log("Hello " + userInputField.text + " !!");
    }
}
