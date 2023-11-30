using StarterAssets;
using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cursor = UnityEngine.Cursor;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject playerArmature;
    private ThirdPersonController thirdPersonController;
    [SerializeField]
    private GameObject gameOver;
    [SerializeField]
    private TMP_Text totalWeightText;
    [SerializeField]
    private Slider timeLeft;
    private float totalWeight;
    private float CORGIWEIGHTOFFSET = 4.0f;
    private bool firstTime = true;

    void Start()
    {
        LoadComponents();
        SetGameOver(false);
    }

    void Update()
    {
        if (timeLeft.value >= timeLeft.maxValue)
        {
            SetGameOver(true);
        }
    }

    // Get all the necessary components
    private void LoadComponents()
    {
        thirdPersonController = playerArmature.GetComponent<ThirdPersonController>();
    }

    private void SetGameOver(bool status)
    {
        gameOver.SetActive(status);

        if (status)
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
            if (firstTime)
            {
                PutWeightInScreen();
            }
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
        }
        Cursor.visible = status;
        thirdPersonController.LockCameraPosition = status;
    }

    private void PutWeightInScreen()
    {
        firstTime = false;
        totalWeight = playerArmature.GetComponent<Weight>().GetWeight() + CORGIWEIGHTOFFSET;
        totalWeight = Mathf.Round(totalWeight * 100f) / 100f;
        totalWeightText.text += totalWeight + " KG";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Playground");
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}