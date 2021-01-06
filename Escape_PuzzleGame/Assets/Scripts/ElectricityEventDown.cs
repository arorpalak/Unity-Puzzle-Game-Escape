﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricityEventDown : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && SoundManagement.instance.audioMaterial.isPlaying == false)
        {
            SoundManagement.instance.PlayElectricity();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && SoundManagement.instance.audioMaterial.isPlaying == true)
        {
            SoundManagement.instance.audioMaterial.Stop();
        }
    }

    /// <summary>
    /// Electricity Down
    /// </summary>
    private void Update()
    {
        //if (InteractionWithPlayer.instance.isGreen)
        //{
        //    Destroy(this.gameObject);
        //}
    }
}
