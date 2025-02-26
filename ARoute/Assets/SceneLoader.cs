using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadPage2()
    {
        SceneManager.LoadScene(1); // Loads in TTSPageTester
    }
    public void LoadPage1()
    {
        SceneManager.LoadScene(0); // Loads in SettingsPage
    }
}
