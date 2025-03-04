using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSettingsPage()
    {
        SceneManager.LoadScene("SettingsPage"); // Loads in SettingsPage
    }
    public void LoadHomePage()
    {
        Debug.Log("🏠 Home Button Clicked");

        if (SceneManager.GetActiveScene().name == "LocationPointer")
        {
            Debug.Log("Already in Home Scene, no need to reload.");
            return;
        }

        SceneManager.LoadScene("GuidePage"); // Loads in LocationPointer Page
    }
}
