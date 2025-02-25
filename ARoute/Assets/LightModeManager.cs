using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LightModeManager : MonoBehaviour
{
    public Image background; // Assign the background UI image
    public TextMeshProUGUI[] texts; // Assign all text elements
    public Button lightModeButton; // Assign the button
    public Button[] buttonsToChange; // Dedicated light mode button
    public Color lightModeButtonColor; // Set light mode color for buttons

    void Start()
    {
        // Attach the event listener only to Light Mode button
        lightModeButton.onClick.AddListener(EnableLightMode);
    }

    public void EnableLightMode()
    {
        Debug.Log("Light Mode Button Clicked!"); // Check if button is being triggered

        // Change UI to Light Mode
        background.color = Color.white; // Light background
        foreach (TextMeshProUGUI txt in texts)
        {
            txt.color = Color.black; // Dark text
        }

        // Change colour of all specified buttons
        foreach (Button btn in buttonsToChange)
        {
            Debug.Log("Changing colour of: " + btn.gameObject.name); // Check which buttons are changing colours, if any

            btn.GetComponent<Image>().color = lightModeButtonColor; // Changes colour of buttons to the chosen colour
        }

        // Save light mode preference
        PlayerPrefs.SetInt("LightMode", 1);
        PlayerPrefs.Save();
    }
}
