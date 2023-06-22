using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource.volume = 0.3f;
    }

    public void MuteSound()
    {
        audioSource.mute = !audioSource.mute;
    }
}
