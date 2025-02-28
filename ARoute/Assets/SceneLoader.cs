using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadPage2()
    {
        SceneManager.LoadScene("TTSPageTester");
    }
    public void LoadPage1()
    {
        SceneManager.LoadScene("SettingsPage");
    }
}
