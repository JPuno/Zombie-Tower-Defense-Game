using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    private void Awake()
    {
        LoadManage();
    }
    void LoadManage()
    {
        DataManager DM = GameObject.FindObjectOfType<DataManager>();
        SoundManager SM = GameObject.FindObjectOfType<SoundManager>();
        if (ES2.Exists("InputName"))
            DM.Name = ES2.Load<string>("InputName");
        if (ES2.Exists("hasName"))
            DM.hasName = ES2.Load<bool>("hasName");
        if (ES2.Exists("Volume"))
            SM.volume = ES2.Load<int>("Volume");
        
    }
    public void Loader()
    {
        DataManager DM = GameObject.FindObjectOfType<DataManager>();
        if (DM.hasName == true)
        {
            SceneManager.LoadScene("SelectLevels");
        }
    }
}
