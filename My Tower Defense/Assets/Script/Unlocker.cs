using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker : MonoBehaviour
{
    public void unlockerlevel2()
    {
        LevelManager LM = GameObject.FindObjectOfType<LevelManager>();
        LM.Level2unlocked = true;
      
        ES2.Save(LM.Level2unlocked, "U2");
    }
    public void unlockerlevel3()
    {
        LevelManager LM = GameObject.FindObjectOfType<LevelManager>();
        LM.Level3unlocked = true;
        
            ES2.Save(LM.Level3unlocked, "U3");
    }
    public void unlockerlevel4()
    {
        LevelManager LM = GameObject.FindObjectOfType<LevelManager>();
        LM.Level4unlocked = true;
        
            ES2.Save(LM.Level4unlocked, "U4");
    }
    public void unlockerlevel5()
    {
        LevelManager LM = GameObject.FindObjectOfType<LevelManager>();
        LM.Level5unlocked = true;
        
            ES2.Save(LM.Level2unlocked, "U5");
    }
    public void unlockerlevel6()
    {
        LevelManager LM = GameObject.FindObjectOfType<LevelManager>();
        LM.Level6unlocked = true;
     
            ES2.Save(LM.Level6unlocked, "U6");
    }
}
