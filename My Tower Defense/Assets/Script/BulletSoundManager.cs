using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSoundManager : MonoBehaviour
{
    public AudioSource source;
   
    void Update()
    {
        Sound();
    }
    void Sound()
    {
        SoundManager SM = GameObject.FindObjectOfType<SoundManager>();

        if (SM.volume == 1)
        {
            source.enabled = false;
            source.mute = true;
            
           
        }
        else
        {
            source.enabled = true;
            source.mute = false;

        }
    }
}
