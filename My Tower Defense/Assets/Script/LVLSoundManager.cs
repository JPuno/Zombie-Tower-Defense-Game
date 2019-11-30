using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVLSoundManager : MonoBehaviour
{
    public AudioSource source;
    public AudioSource source2;
    public AudioSource source3;
   
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
            source2.enabled = false;
            source3.enabled = false;
        }
        else
        {
            source.enabled = true;
            source2.enabled = true;
            source3.enabled = true;
        }
    }
}
