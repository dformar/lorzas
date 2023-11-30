using StarterAssets;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cursor = UnityEngine.Cursor;

public class PauseButton : MonoBehaviour
{
    private bool isPaused;
    [SerializeField]
    private GameObject playerArmature;
    private ThirdPersonController thirdPersonController;
    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private Slider timeLeft;

    void Start()
    {
        thirdPersonController = playerArmature.GetComponent<ThirdPersonController>();
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && timeLeft.value < timeLeft.maxValue)
        {
            PauseController();
        }
    }

    private void PauseController()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        Cursor.visible = isPaused;
        Time.timeScale = isPaused ? 0 : 1;
        thirdPersonController.LockCameraPosition = isPaused;
        pauseMenu.SetActive(isPaused);
    }

    public void ResumeGame()
    {
        PauseController();
    }

    public void GameSettings()
    {
        // Game Settings -- Sprint 2
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}