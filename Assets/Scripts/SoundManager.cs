using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip klik;
    public AudioSource audioSrc;

    void Start()
    {
        
        audioSrc = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        audioSrc.PlayOneShot(klik);
    }
}
