//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;

//public class DarkModeScript : MonoBehaviour
//{
//    public Image background;
//    public TextMeshProUGUI[] texts;
//    public Button darkModeButton;
//    public Button[] buttonsToChange;
//    public Color darkModeButtonColor;
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

//        if (savedTheme == 0)
//        {
//            ApplyDarkMode();
//        }

//        if (darkModeButton != null)
//        {
//            darkModeButton.onClick.RemoveAllListeners();
//            darkModeButton.onClick.AddListener(EnableDarkMode);
//        }
//    }

//    public void EnableDarkMode()
//    {
//        Debug.Log("Dark Mode Button Clicked!");

//        // Save Dark Mode Preference#
//        PlayerPrefs.SetInt("ThemeSelected", 1);
//        PlayerPrefs.SetInt("LightMode", 0);
//        PlayerPrefs.Save();

//        ApplyDarkMode();
//    }

//    private void ApplyDarkMode()
//    {
//        // Change UI to Dark Mode
//        background.color = Color.gray;
//        buttonsBox.color = Color.black;

//        foreach (TextMeshProUGUI txt in texts)
//        {
//            txt.color = Color.white;
//        }

//        foreach (Button btn in buttonsToChange)
//        {
//            btn.GetComponent<Image>().color = darkModeButtonColor;
//        }
//    }
//}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DarkModeScript : MonoBehaviour
{
    public Image background;
    public TextMeshProUGUI[] texts;
    public Button darkModeButton;
    public Button[] buttonsToChange;
    public Color darkModeButtonColor;
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

        // Apply Dark Mode if it was selected in this session
        if (PlayerPrefs.GetInt("LightMode", -1) == 0)
        {
            ApplyDarkMode();
        }

        if (darkModeButton != null)
        {
            darkModeButton.onClick.RemoveAllListeners();
            darkModeButton.onClick.AddListener(EnableDarkMode);
        }
    }

    public void EnableDarkMode()
    {
        Debug.Log("Dark Mode Button Clicked!");

        // Save Dark Mode preference for this session only
        PlayerPrefs.SetInt("LightMode", 0);
        PlayerPrefs.Save();

        ApplyDarkMode();
    }

    private void ApplyDarkMode()
    {
        background.color = Color.gray;
        buttonsBox.color = Color.black;

        foreach (TextMeshProUGUI txt in texts)
        {
            txt.color = Color.white;
        }

        foreach (Button btn in buttonsToChange)
        {
            btn.GetComponent<Image>().color = darkModeButtonColor;
        }
    }
}

