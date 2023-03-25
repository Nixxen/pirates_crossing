using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBackground : MonoBehaviour
{
    public AudioSource src;

    public AudioClip backgroundMusic;
    
    void Start()
    {
        src.PlayOneShot(backgroundMusic);
    }


}
