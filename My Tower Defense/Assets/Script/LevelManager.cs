using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public bool Level2unlocked=false;
    public bool Level3unlocked=false;
    public bool Level4unlocked=false;
    public bool Level5unlocked=false;
    public bool Level6unlocked=false;
    public static int score1;
    public static int score2;
    public static int score3;
    public static int score4;
    public static int score5;
    public static int score6;

    static LevelManager instance = null;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
   
}
