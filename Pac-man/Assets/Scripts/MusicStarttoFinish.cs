using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStarttoFinish : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip introMusic;
    public AudioClip normalStateMusic;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = introMusic;
        audioSource.Play();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = normalStateMusic;
            audioSource.Play();
        }
    }
}
