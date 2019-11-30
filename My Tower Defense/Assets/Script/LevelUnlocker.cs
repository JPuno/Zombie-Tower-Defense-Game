using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;
    private void Awake()
    {
        LevelManager LM = GameObject.FindObjectOfType<LevelManager>();
        if (ES2.Exists("U2"))
        {
            LM.Level2unlocked = ES2.Load<bool>("U2");
        }
        else
        {
            LM.Level2unlocked = false;
        }
        if (ES2.Exists("U3"))
        {
            LM.Level3unlocked = ES2.Load<bool>("U3");
        }
        else
        {
            LM.Level3unlocked = false;
        }
        if (ES2.Exists("U4"))
        {
            LM.Level4unlocked = ES2.Load<bool>("U4");
        }
        else
        {
            LM.Level4unlocked = false;
        }
        if (ES2.Exists("U5"))
        {
            LM.Level5unlocked = ES2.Load<bool>("U5");
        }
        else
        {
            LM.Level5unlocked = false;
        }
        if (ES2.Exists("U6"))
        {
            LM.Level6unlocked = ES2.Load<bool>("U6");
        }
        else
        {
            LM.Level6unlocked = false;
        }
    }
    private void Update()
    {
        Unlocked();
    }
    void Unlocked()
    {
        LevelManager LM = GameObject.FindObjectOfType<LevelManager>();
        if (LM.Level2unlocked == true)
        {
            level2.enabled = true;
        }
        if (LM.Level3unlocked == true)
        {
            level3.enabled = true;
        }
        if (LM.Level4unlocked == true)
        {
            level4.enabled = true;
        }
        if (LM.Level5unlocked == true)
        {
            level5.enabled = true;
        }
        if (LM.Level6unlocked == true)
        {
            level6.enabled = true;
        }
    }
}
