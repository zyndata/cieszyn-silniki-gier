using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{

    public void OnBackClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
