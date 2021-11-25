using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LevelFinish")
        {
            SceneManager.LoadScene("GameEnd");
        }

        if (other.gameObject.tag == "WorldEnd")
        {
            transform.position = new Vector3(2.4f, 2.0f, 2.95f);
        }

    }


}
