using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadPage2()
    {
        Debug.Log("Button Getting Clicked"); // Testing whether button gets clicked
        SceneManager.LoadScene("TTSPageTester"); // Loads in TTSPageTester
    }
    public void LoadPage1()
    {
        SceneManager.LoadScene("SettingsPage"); // Loads in SettingsPage
    }

    //private void Start()
    //{
    //    SceneManager.LoadScene("TTSPageTester");
    //}
}
