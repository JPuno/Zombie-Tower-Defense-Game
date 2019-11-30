using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public InputField Name;
    public GameObject pop;
    public GameObject Warning;

   public void SaveInputName()
    {

        DataManager DM = GameObject.FindObjectOfType<DataManager>();
        if (Name.text!="" && DM.hasName == false)
        {
            DM.Name = Name.text;
            DM.hasName = true;
            ES2.Save(DM.Name, "InputName");
            ES2.Save(DM.hasName, "hasName");
            ChangeScene.SManager();
        }
        else if(Name.text != "" && DM.hasName == true)
        {
            pop.SetActive(true);
            Warning.SetActive(false);
        }
        else
        {
            Warning.SetActive(true);
        }
    }
    public void OverWriteSave()
    {
        DataManager DM = GameObject.FindObjectOfType<DataManager>();
        DM.Name = Name.text;
        DM.hasName = true;
        if (ES2.Exists("InputName"))
            ES2.Save(DM.Name, "InputName");
        if (ES2.Exists("hasName"))
            ES2.Save(DM.hasName, "hasName");
        if (ES2.Exists("U2"))
            ES2.Delete("U2");
        if (ES2.Exists("U3"))
            ES2.Delete("U3");
        if (ES2.Exists("U4"))
            ES2.Delete("U4");
        if (ES2.Exists("U5"))
            ES2.Delete("U5");
        if (ES2.Exists("U6"))
            ES2.Delete("U6");

        if (ES2.Exists("H1"))
            ES2.Delete("H1");
        if (ES2.Exists("H2"))
            ES2.Delete("H2");
        if (ES2.Exists("H3"))
            ES2.Delete("H3");
        if (ES2.Exists("H4"))
            ES2.Delete("H4");
        if (ES2.Exists("H5"))
            ES2.Delete("H5");
        if (ES2.Exists("H6"))
            ES2.Delete("H6");
    }
    public void SaveVolume()
    {
        SoundManager SM = GameObject.FindObjectOfType<SoundManager>();
        ES2.Save(SM.volume, "Volume");
    }
    public void No()
    {
        Name.text = "";
    }
}
