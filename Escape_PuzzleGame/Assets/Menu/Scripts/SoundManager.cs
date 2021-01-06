using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;


    public AudioSource audioMaterials;

    public AudioClip mouseover, click;

    private void Awake()
    {
        instance = this;

        audioMaterials = GetComponent<AudioSource>();
    }


    /// <summary>
    /// Mouseover Event;
    /// </summary>
    public void PlayMouseOverAudio()
    {
        audioMaterials.PlayOneShot(mouseover);
    }

    /// <summary>
    /// Click Event;
    /// </summary>
    public void PlayClickAudio()
    {
        audioMaterials.PlayOneShot(click);
    }
}
