using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    [SerializeField]
    private Button JButton;

    //Return to main menu screen
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ButtonPush()
    {
    }

    public void OButton()
    {
        JButton.interactable = true;
    }
}
