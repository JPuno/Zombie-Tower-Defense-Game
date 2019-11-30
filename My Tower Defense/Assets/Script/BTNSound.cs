using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BTNSound : MonoBehaviour, IPointerEnterHandler
{
    public AudioSource Audio;
    public AudioClip btnclip;
   
    public void BTNClick(AudioClip clip)
    {
        
        Audio.PlayOneShot(clip);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Audio.PlayOneShot(btnclip);
    }

  
}
