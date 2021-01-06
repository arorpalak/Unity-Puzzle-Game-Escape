using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickSound : MonoBehaviour,IPointerClickHandler
{

    /// <summary>
    /// Click Event
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerClick(PointerEventData eventData)
    {
        SoundManager.instance.PlayMouseOverAudio();
    }

}
