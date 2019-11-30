using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public int highScore1;
    public int highScore2;
    public int highScore3;
    public int highScore4;
    public int highScore5;
    public int highScore6;
    public Text HScore1;
    public Text HScore2;
    public Text HScore3;
    public Text HScore4;
    public Text HScore5;
    public Text HScore6;

    private void Update()
    {
        if(highScore1==0)
        {
            HScore1.enabled = false;
        }
        else
        {
            HScore1.enabled = true;
        }
        if (highScore2 == 0)
        {
            HScore2.enabled = false;
        }
        else
        {
            HScore2.enabled = true;
        }
        if (highScore3 == 0)
        {
            HScore3.enabled = false;
        }
        else
        {
            HScore3.enabled = true;
        }
        if (highScore4 == 0)
        {
            HScore4.enabled = false;
        }
        else
        {
            HScore4.enabled = true;
        }
        if (highScore5 == 0)
        {
            HScore5.enabled = false;
        }
        else
        {
            HScore5.enabled = true;
        }
        if (highScore6 == 0)
        {
            HScore6.enabled = false;
        }
        else
        {
            HScore6.enabled = true;
        }
        HighScored();
    }
    void HighScored()
    {
        HScore1.text = highScore1.ToString();
        HScore2.text = highScore2.ToString();
        HScore3.text = highScore3.ToString();
        HScore4.text = highScore4.ToString();
        HScore5.text = highScore5.ToString();
        HScore6.text = highScore6.ToString();
        if (LevelManager.score1 > highScore1)
        {
            highScore1 = LevelManager.score1;
            ES2.Save(LevelManager.score1, "H1");
        }
        if (LevelManager.score2 > highScore2)
        {
            highScore2 = LevelManager.score2;
            ES2.Save(LevelManager.score2, "H2");
        }
        if (LevelManager.score3 > highScore3)
        {
            highScore3 = LevelManager.score3;
          
            ES2.Save(LevelManager.score3, "H3");
        }
        if (LevelManager.score4 > highScore4)
        {
            highScore4 = LevelManager.score4;
            
            ES2.Save(LevelManager.score4, "H4");
        }
        if (LevelManager.score5 > highScore5)
        {
            highScore5 = LevelManager.score5;
          
            ES2.Save(LevelManager.score5, "H5");
        }
        if (LevelManager.score6 > highScore6)
        {
            highScore6 = LevelManager.score6;
           
            ES2.Save(LevelManager.score6, "H6");
        }
    }
    private void Awake()
    {
        if (ES2.Exists("H1"))
            highScore1= ES2.Load<int>("H1");
        if (ES2.Exists("H2"))
            highScore2 = ES2.Load<int>("H2");
        if (ES2.Exists("H3"))
            highScore3= ES2.Load<int>("H3");
        if (ES2.Exists("H4"))
            highScore4= ES2.Load<int>("H4");
        if (ES2.Exists("H5"))
            highScore5 = ES2.Load<int>("H5");
        if (ES2.Exists("H6"))
            highScore6 = ES2.Load<int>("H6");

    }
}
