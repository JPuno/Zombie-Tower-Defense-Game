using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SceneManage(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public static void SManager()
    {
        SceneManager.LoadScene("SelectLevels");
    }
}
