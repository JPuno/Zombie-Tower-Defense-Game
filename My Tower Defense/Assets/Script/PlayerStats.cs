using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int Lives;
    public Text liveText;

    private void Update()
    {
        liveText.text = Lives.ToString();
    }
}
