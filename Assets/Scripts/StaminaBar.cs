using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{

    public Slider StaminaSlider;

    public GameObject Player;
    private Stamina PlayerStamina;
    // Start is called before the first frame update
    void Start()
    {
        PlayerStamina = this.Player.GetComponent<Stamina>();
    }

    // Update is called once per frame
    void Update()
    {
        this.StaminaSlider.value = this.PlayerStamina.GetEnergy() / this.PlayerStamina.GetMaximumEnergy();
    }
}
