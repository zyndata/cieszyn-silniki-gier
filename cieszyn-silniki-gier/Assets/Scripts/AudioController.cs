using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{


    public AudioClip stepClip;

    public AudioSource audioSource;


    public void Step()
    {
        audioSource.PlayOneShot(stepClip);
    }

}
