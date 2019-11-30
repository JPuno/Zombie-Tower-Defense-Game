using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    private bool isPaused=false;
    public GameObject PauseMenu;
    void Update()
    {
        if (isPaused == true)
        {
            Paused();
        }
        else
        {
            Resume();
        }
    }

   public void Paused()
    {
        
        LVLSoundManager LS = GameObject.FindObjectOfType<LVLSoundManager>();
        LS.source.mute = true;
        LS.source2.mute = true;
        LS.source3.mute = true;
        isPaused = true;
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        LVLSoundManager LS = GameObject.FindObjectOfType<LVLSoundManager>();
        LS.source.mute  = false;
        LS.source3.mute = false;
        isPaused = false;
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }
}
