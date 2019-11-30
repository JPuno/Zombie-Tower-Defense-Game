using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skill2 : MonoBehaviour
{
    private bool hasbeenUse = false;
    private bool hasbeenUsed = false;
    public int speed;
    private float CD = 30f;
    private float timelimit = 10f;
    private Soldier[] S;
    public Text CDtext;
    public GameObject popCD;
    private void Update()
    {
        CoolDown();
    }
    public void PowerUp(int PowerUpSpeed)
    {
        S = GameObject.FindObjectsOfType<Soldier>();
        if (S[0] != null && hasbeenUse == false)
        {

            hasbeenUse = true;
            hasbeenUsed = true;
            for (int i = 0; i < S.Length; i++)
            {

                S[i].Speed += PowerUpSpeed;
            }
        }
    }
    void CoolDown()
    {
       
        CDtext.text = CD.ToString("00");
        if (S != null && hasbeenUse == true)
        {
            CD -= Time.deltaTime;
            CD = Mathf.Clamp(CD, 0f, Mathf.Infinity);
            popCD.SetActive(true);
            if (CD <= 0)
            {
                hasbeenUse = false;
                CD = 30f;
                popCD.SetActive(false);
            }
            if (hasbeenUsed == true)
            {
                
                timelimit -= Time.deltaTime;
                timelimit = Mathf.Clamp(timelimit, 0f, Mathf.Infinity);
                if (timelimit <= 0)
                {
                    hasbeenUsed = false;
                    timelimit = 10f;
                    for (int i = 0; i < S.Length; i++)
                    {

                        S[i].Speed -= speed;
                    }
                }
            }
        }
    }
}
