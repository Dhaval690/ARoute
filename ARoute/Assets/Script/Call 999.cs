using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EmergencyUI : MonoBehaviour
{
    public Button helpTeamButton;
    public Button emergencyButton;
    public Button homeButton;
    public Button mapButton;
    public Button profileButton;

    void Start()
    {
        // Ensure buttons are assigned before adding listeners
        if (helpTeamButton != null) helpTeamButton.onClick.AddListener(CallHelpTeam);
        if (emergencyButton != null) emergencyButton.onClick.AddListener(CallEmergency);
        if (homeButton != null) homeButton.onClick.AddListener(GoToHome);
        if (mapButton != null) mapButton.onClick.AddListener(GoToMap);
        if (profileButton != null) profileButton.onClick.AddListener(GoToProfile);
    }

    void CallHelpTeam()
    {
        Debug.Log("Calling Help Team...");
        Application.OpenURL("tel://+441772892068"); // Replace with actual number
    }

    void CallEmergency()
    {
        Debug.Log("Calling 999...");
        Application.OpenURL("tel://999");
    }

    void GoToHome()
    {
        Debug.Log("Navigating to Home Scene...");
        SceneManager.LoadScene("HomeScene"); // Ensure this scene exists in Build Settings
    }

    void GoToMap()
    {
        Debug.Log("Navigating to Map Scene...");
        SceneManager.LoadScene("MapScene");
    }

    void GoToProfile()
    {
        Debug.Log("Navigating to Profile Scene...");
        SceneManager.LoadScene("ProfileScene");
    }
}

