using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagement : MonoBehaviour
{
    public static SoundManagement instance;

    public AudioClip electricity, poopExlosion;

    public AudioSource audioMaterial;

    private void Awake()
    {
        instance = this;

        audioMaterial = GetComponent<AudioSource>();
    }



    public void PlayElectricity()
    {

        audioMaterial.PlayOneShot(electricity);
    }

    public void PlayPoopExplosion()
    {

        audioMaterial.PlayOneShot(poopExlosion);
    }


}
