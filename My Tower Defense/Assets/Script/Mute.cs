using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
   
    public AudioSource Source;
    public Image btnimageSource;
    public Sprite mute;
    public Sprite unMute;
    private void Update()
    {
        Muted();
    }
    public void SoundOn()
    {
        SoundManager SM = GameObject.FindObjectOfType<SoundManager>();
        if (SM.volume==0)
        {
            SM.volume = 1;
            Source.enabled = false;
            btnimageSource.sprite = mute;
        }
        else
        {
            SM.volume = 0;
            Source.enabled = true;
            btnimageSource.sprite = unMute;
        }
    }
    void Muted()
    {
        SoundManager SM = GameObject.FindObjectOfType<SoundManager>();
        if (SM.volume == 1)
        {
           
            Source.enabled = false;
            btnimageSource.sprite = mute;
        }
        else
        {
          
            Source.enabled = true;
            btnimageSource.sprite = unMute;
        }
    }
}
