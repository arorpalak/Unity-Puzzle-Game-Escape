using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEffect : MonoBehaviour,IPointerEnterHandler, IPointerDownHandler
{
    /// <summary>
    /// Click Effect
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerDown(PointerEventData eventData)
    {
        SoundManager.instance.PlayClickAudio();
    }

    /// <summary>
    /// Mouseover Effect
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerEnter(PointerEventData eventData)
    {
        SoundManager.instance.PlayMouseOverAudio();
    }




}
