//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;

//public class LightModeManager : MonoBehaviour
//{
//    public Image background;
//    public TextMeshProUGUI[] texts;
//    public Button lightModeButton;
//    public Button[] buttonsToChange;
//    public Color lightModeButtonColor;
//    public Image buttonsBox;

//    void Start()
//    {
//        // Do not apply any theme if the user has not selected one before
//        if (!PlayerPrefs.HasKey("ThemeSelected"))
//        {
//            Debug.Log("First-time launch: No theme applied yet.");
//            return;
//        }

//        // Load saved theme
//        int savedTheme = PlayerPrefs.GetInt("LightMode", -1);
//        Debug.Log("Loaded theme from PlayerPrefs: " + savedTheme);

//        PlayerPrefs.DeleteAll();
//        PlayerPrefs.Save();
//        Debug.Log("playerprefs reset!");

//        if (savedTheme == 1)
//        {
//            ApplyLightMode();
//        }

//        if (lightModeButton != null)
//        {
//            lightModeButton.onClick.RemoveAllListeners();
//            lightModeButton.onClick.AddListener(EnableLightMode);
//        }
//    }

//    public void EnableLightMode()
//    {
//        Debug.Log("Light Mode Button Clicked!");

//        // Save Light Mode Preference
//        PlayerPrefs.SetInt("ThemeSelected", 1);
//        PlayerPrefs.SetInt("LightMode", 0);
//        PlayerPrefs.Save();

//        ApplyLightMode();
//    }

//    private void ApplyLightMode()
//    {
//        // Change UI to Light Mode
//        background.color = Color.white;
//        buttonsBox.color = Color.gray;

//        foreach (TextMeshProUGUI txt in texts)
//        {
//            txt.color = Color.black;
//        }

//        foreach (Button btn in buttonsToChange)
//        {
//            btn.GetComponent<Image>().color = lightModeButtonColor;
//        }
//    }
//}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LightModeScript : MonoBehaviour
{
    public Image background;
    public TextMeshProUGUI[] texts;
    public Button lightModeButton;
    public Button[] buttonsToChange;
    public Color lightModeButtonColor;
    public Image buttonsBox;

    void Awake() // Reset before Unity loads anything
    {
        Debug.Log("Resetting theme on Unity restart...");
        PlayerPrefs.DeleteAll(); // FULL RESET
        PlayerPrefs.Save();
    }

    void Start()
    {
        Debug.Log("Checking if theme was selected...");

        // If no mode was selected in this session, do nothing (default screen)
        if (!PlayerPrefs.HasKey("LightMode"))
        {
            Debug.Log("Default screen shown. No mode applied.");
            return;
        }

        // Apply Light Mode if it was selected in this session
        if (PlayerPrefs.GetInt("LightMode", -1) == 1)
        {
            ApplyLightMode();
        }

        if (lightModeButton != null)
        {
            lightModeButton.onClick.RemoveAllListeners();
            lightModeButton.onClick.AddListener(EnableLightMode);
        }
    }

    public void EnableLightMode()
    {
        Debug.Log("Light Mode Button Clicked!");

        // Save Light Mode preference for this session only
        PlayerPrefs.SetInt("LightMode", 1);
        PlayerPrefs.Save();

        ApplyLightMode();
    }

    private void ApplyLightMode()
    {
        background.color = Color.white;
        buttonsBox.color = Color.gray;

        foreach (TextMeshProUGUI txt in texts)
        {
            txt.color = Color.black;
        }

        foreach (Button btn in buttonsToChange)
        {
            btn.GetComponent<Image>().color = lightModeButtonColor;
        }
    }
}

