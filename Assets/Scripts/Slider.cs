using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider countdownSlider;
    public float countdownTime;
    private float sliderValue = 0.0f;

    void Start()
    {
        countdownSlider.maxValue = countdownTime;
    }

    void Update()
    {
        if (countdownTime > 0)
        {
            countdownTime -= Time.deltaTime;
            sliderValue += Time.deltaTime;
            UpdateTimerUI();
        }
    }

    void UpdateTimerUI()
    {
        countdownSlider.value = sliderValue;
    }
}
